using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class HavaleOdeme : IOdemeStratejisi
    {
        public bool OdemeYap(decimal tutar)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"{tutar} TL için Havale/EFT bekleniyor.");
            return true;
        }
    }
}
