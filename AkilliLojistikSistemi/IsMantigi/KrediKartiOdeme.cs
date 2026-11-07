using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class KrediKartiOdeme : IOdemeStratejisi
    {
        public bool OdemeYap(decimal tutar)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"{tutar} TL Kredi Kartı ile başarıyla çekildi.");
            return true;
        }
    }
}
