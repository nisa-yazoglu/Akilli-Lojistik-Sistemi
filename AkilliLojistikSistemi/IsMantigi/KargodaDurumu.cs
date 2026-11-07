using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class KargodaDurumu : ISiparisDurumu
    {
        public void SonrakiAsamayaGec(Modeller.Siparis siparis)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Sipariş {siparis.Id} müşteriye teslim edildi.");

            siparis.MevcutDurum = new TeslimEdildiDurumu();
        }

        public void IptalEt(Modeller.Siparis siparis)
        {
            System.Windows.Forms.MessageBox.Show("Uyarı: Ürün kargoya verildiği için İPTAL EDİLEMEZ. Ancak teslim alındıktan sonra İADE edilebilir.");
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"Kargodaki sipariş {siparis.Id} iptal edilmeye çalışıldı ancak reddedildi.");
        }

        public string DurumYazdir()
        {
            return "Kargoda";
        }
    }
}