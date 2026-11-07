using System;
using System.Windows.Forms;
using AkilliLojistikSistemi.Modeller;
using AkilliLojistikSistemi.IsMantigi;
using AkilliLojistikSistemi.VeriErisim;

namespace AkilliLojistikSistemi
{
    public partial class Form1 : Form
    {
        BasitUrun klavye = null!;
        KarmasikUrun kasa = null!;

        StokTakipServisi stokServisi = null!;
        Siparis aktifSiparis = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log_Servisi.Ornek.ArayuzLogKutusu = lstLog;

            stokServisi = new StokTakipServisi();
            stokServisi.GozlemciEkle(new SatinAlmaGozlemcisi());
            stokServisi.GozlemciEkle(new DepoGozlemcisi());

            klavye = new BasitUrun { Ad = "Oyuncu Klavyesi", Fiyat = 1500, Stok = 15 };

            kasa = new KarmasikUrun { Ad = "Bilgisayar Kasası", Stok = 15 };
            kasa.ParcaEkle(new BasitUrun { Ad = "Anakart", Fiyat = 5000, Stok = 100 });
            kasa.ParcaEkle(new BasitUrun { Ad = "İşlemci", Fiyat = 15000, Stok = 100 });

            cmbRol.Items.AddRange(new string[] { "Yönetici", "Depo Personeli", "Müşteri" });
            cmbRol.SelectedIndex = 2;

            cmbKargo.Items.AddRange(new string[] { "Aras", "Yurtici", "GlobalExpres", "PTT" });
            cmbKargo.SelectedIndex = 0;

            cmbOdeme.Items.AddRange(new string[] { "Kredi Kartı", "Havale", "Kripto" });
            cmbOdeme.SelectedIndex = 0;

            cmbUrun.Items.AddRange(new string[] { "Oyuncu Klavyesi (Basit Ürün)", "Oyun Bilgisayarı Kasası (Karmaşık Ürün)" });
            cmbUrun.SelectedIndex = 0;

            lblStok.Text = $"Kalan Stok: {klavye.Stok}";

            Log_Servisi.Ornek.LogKaydet("Sistem başlatıldı. Hoş geldiniz.", lstLog);
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedIndex == 0) lblStok.Text = $"Kalan Stok: {klavye.Stok}";
            else lblStok.Text = $"Kalan Stok: {kasa.Stok}";
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Depo Personeli")
            {
                MessageBox.Show("Depo Sorumlusu sipariş oluşturamaz! Sadece Yönetici ve Müşteriler sipariş verebilir.", "Yetki İhlali", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Log_Servisi.Ornek.LogKaydet(">>> Yeni Sipariş Başlatıldı <<<", lstLog);

            decimal odenecekTutar = 0;

            if (cmbUrun.SelectedIndex == 0)
            {
                if (klavye.Stok <= 0)
                {
                    MessageBox.Show("Ürün tükendi!");
                    return;
                }
                odenecekTutar = klavye.FiyatHesapla();
                klavye.Stok--;
                lblStok.Text = $"Kalan Stok: {klavye.Stok}";
                stokServisi.StokKontrolEt(klavye);
            }
            else
            {
                if (kasa.Stok <= 0)
                {
                    MessageBox.Show("Kasa tükendi!");
                    return;
                }
                odenecekTutar = kasa.FiyatHesapla();
                kasa.Stok--;
                lblStok.Text = $"Kalan Stok: {kasa.Stok}";
                stokServisi.StokKontrolEt(kasa);
            }

            aktifSiparis = new Siparis { Id = new Random().Next(1000, 9999) };

            IOdemeStratejisi odemeYontemi;

            if (cmbOdeme.Text == "Havale")
                odemeYontemi = new HavaleOdeme();
            else if (cmbOdeme.Text == "Kripto")
                odemeYontemi = new KriptoOdeme();
            else
                odemeYontemi = new KrediKartiOdeme();

            aktifSiparis.OdemeAl(odemeYontemi, odenecekTutar);

            IKargoServisi kargoFirmasi = KargoFabrikasi.KargoOlustur(cmbKargo.Text);

            if (chkSigorta.Checked)
            {
                kargoFirmasi = new SigortaliKargo(kargoFirmasi);
            }

            if (chkKirilacak.Checked)
            {
                kargoFirmasi = new KirilacakEsyaKargo(kargoFirmasi);
            }

            decimal kargoUcreti = kargoFirmasi.FiyatHesapla(2.5, 150);

            Log_Servisi.Ornek.LogKaydet($"Sipariş Tamamlandı. Sepet: {odenecekTutar} TL, Kargo: {kargoUcreti} TL", lstLog);
            Log_Servisi.Ornek.LogKaydet("--------------------------------", lstLog);
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Kullanici aktifKullanici = new Kullanici { Ad = "Test Kullanıcısı" };
            if (cmbRol.Text == "Yönetici") aktifKullanici.Rol = KullaniciRolu.Admin;
            else if (cmbRol.Text == "Depo Personeli") aktifKullanici.Rol = KullaniciRolu.Personel;
            else aktifKullanici.Rol = KullaniciRolu.Musteri;

            ISistemIslemleri sistem = new YetkiKontrolProxy(aktifKullanici);

            sistem.StokGuncelle(cmbUrun.Text, 50);

            if (aktifKullanici.Rol != KullaniciRolu.Musteri)
            {
                if (cmbUrun.SelectedIndex == 0) klavye.Stok += 50;
                else kasa.Stok += 50;

                cmbUrun_SelectedIndexChanged(null, null);
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Müşteri")
            {
                lstLog.Visible = false;
                btnDurumIlerlet.Visible = false;
                btnIptalIade.Visible = true;
            }
            else if (cmbRol.Text == "Depo Personeli")
            {
                lstLog.Visible = true;
                btnDurumIlerlet.Visible = true;
                btnIptalIade.Visible = false;
            }
            else if (cmbRol.Text == "Yönetici")
            {
                lstLog.Visible = true;
                btnDurumIlerlet.Visible = true;
                btnIptalIade.Visible = true;
            }
        }

        private void cmbOdeme_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnDurumuIlerlet_Click(object sender, EventArgs e)
        {
            if (aktifSiparis == null)
            {
                MessageBox.Show("Önce bir sipariş oluşturmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            aktifSiparis.SonrakiAsamayaGec();
        }

        private void btnIptalIade_Click(object sender, EventArgs e)
        {
            if (aktifSiparis == null)
            {
                MessageBox.Show("Ortada iptal edilecek bir sipariş yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            aktifSiparis.IptalEt();
        }
    }
}