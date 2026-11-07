using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class ArasKargo : IKargoServisi
    {
        public string TakipNoOlustur() => "ARAS-" + System.Guid.NewGuid().ToString().Substring(0, 8);

        public decimal FiyatHesapla(double agirlik, double mesafe)
        {
            return 50 + (decimal)(agirlik * 5);
        }
    }
}
