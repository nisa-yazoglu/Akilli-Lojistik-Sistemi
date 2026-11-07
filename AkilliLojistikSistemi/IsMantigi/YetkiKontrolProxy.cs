using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class YetkiKontrolProxy : ISistemIslemleri
    {
        private GercekSistem _gercekSistem;
        private Modeller.Kullanici _aktifKullanici;

        public YetkiKontrolProxy(Modeller.Kullanici kullanici)
        {
            _aktifKullanici = kullanici;
            _gercekSistem = new GercekSistem();
        }

        public void StokGuncelle(string urunAdi, int miktar)
        {
            if (_aktifKullanici.Rol == Modeller.KullaniciRolu.Admin || _aktifKullanici.Rol == Modeller.KullaniciRolu.Personel)
            {
                _gercekSistem.StokGuncelle(urunAdi, miktar);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Yetki Hatası: Müşteriler stok güncelleyemez!");
                VeriErisim.Log_Servisi.Ornek.LogKaydet($"YETKİ İHLALİ DENEMESİ: {_aktifKullanici.Ad} (Müşteri) stok güncellemeye çalıştı.");
            }
        }

        public void SiparisVer()
        {
            _gercekSistem.SiparisVer();
        }
    }
}
