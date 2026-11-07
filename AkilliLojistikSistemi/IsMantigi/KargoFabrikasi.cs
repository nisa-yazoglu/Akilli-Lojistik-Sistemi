using AkilliLojistikSistemi.IsMantigi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public static class KargoFabrikasi
    {
        public static IKargoServisi KargoOlustur(string firmaAdi)
        {
            if (firmaAdi == "Aras")
            {
                return new ArasKargo();
            }
            else if (firmaAdi == "Yurtici")
            {
                return new YurticiKargo();
            }
            else if (firmaAdi == "GlobalExpres")
            {
                return new GlobalExpres();
            }
            else if (firmaAdi == "PTT")
            {
                return new PttKargoAdapter();
            }

            throw new System.Exception("Geçersiz kargo firması seçimi.");
        }
    }
}