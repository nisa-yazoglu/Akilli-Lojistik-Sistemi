using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public abstract class KargoDecorator : IKargoServisi
    {
        protected IKargoServisi _sarmalananKargo;

        public KargoDecorator(IKargoServisi sarmalananKargo)
        {
            _sarmalananKargo = sarmalananKargo;
        }

        public virtual decimal FiyatHesapla(double agirlik, double mesafe)
        {
            return _sarmalananKargo.FiyatHesapla(agirlik, mesafe);
        }

        public string TakipNoOlustur()
        {
            return _sarmalananKargo.TakipNoOlustur();
        }
    }
}
