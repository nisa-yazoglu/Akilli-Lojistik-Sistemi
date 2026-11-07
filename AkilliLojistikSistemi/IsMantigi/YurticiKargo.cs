using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class YurticiKargo : IKargoServisi
    {
        public string TakipNoOlustur() => "YURT-" + System.Random.Shared.Next(1000, 9999);

        public decimal FiyatHesapla(double agirlik, double mesafe)
        {
            return 30 + (decimal)(mesafe * 0.5);
        }
    }
}
