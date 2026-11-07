using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class SigortaliKargo : KargoDecorator
    {
        public SigortaliKargo(IKargoServisi sarmalananKargo) : base(sarmalananKargo) { }

        public override decimal FiyatHesapla(double agirlik, double mesafe)
        {
            return base.FiyatHesapla(agirlik, mesafe) + 50.0m;
        }
    }
}
