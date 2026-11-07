using AkilliLojistikSistemi.IsMantigi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.Modeller
{
    public class Siparis
    {
        public int Id { get; set; }

        public ISiparisDurumu MevcutDurum {  get; set; }

        public Siparis()
        {
            MevcutDurum = new BeklemedeDurumu();
        }

        public void SonrakiAsamayaGec()
        {
            MevcutDurum.SonrakiAsamayaGec(this);
        }

        public void IptalEt()
        {
            MevcutDurum.IptalEt(this);
        }

        public void OdemeAl(IOdemeStratejisi odemeYontemi, decimal tutar)
        {
            bool basarili = odemeYontemi.OdemeYap(tutar);
            if (basarili)
            {
                SonrakiAsamayaGec();
            }
        }
    }
}
