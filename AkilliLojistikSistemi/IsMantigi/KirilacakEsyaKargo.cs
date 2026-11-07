using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class KirilacakEsyaKargo : KargoDecorator
    {
        public KirilacakEsyaKargo(IKargoServisi sarmalananKargo) : base(sarmalananKargo) { }

        public override decimal FiyatHesapla(double agirlik, double mesafe)
        {
            decimal temelFiyat = base.FiyatHesapla(agirlik, mesafe);

            return temelFiyat + (temelFiyat * 0.20m);
        }
    }
}
