using AkilliLojistikSistemi.IsMantigi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class GlobalExpres : IKargoServisi
    {
        public string TakipNoOlustur() => "GLB-" + System.Guid.NewGuid().ToString().Substring(0, 6).ToUpper();

        public decimal FiyatHesapla(double agirlik, double mesafe)
        {
            decimal tabanFiyat = 100;

            return tabanFiyat;
        }
    }
}
