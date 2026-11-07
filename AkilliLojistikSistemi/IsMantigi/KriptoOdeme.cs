using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class KriptoOdeme : IOdemeStratejisi
    {
        public bool OdemeYap(decimal tutar)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"{tutar} TL karşılığı Kripto para cüzdandan transfer edildi.");
            return true;
        }
    }
}
