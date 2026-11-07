using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public interface ISiparisDurumu
    {
        void SonrakiAsamayaGec(Modeller.Siparis siparis);

        void IptalEt(Modeller.Siparis siparis);
        string DurumYazdir();
    }
}
