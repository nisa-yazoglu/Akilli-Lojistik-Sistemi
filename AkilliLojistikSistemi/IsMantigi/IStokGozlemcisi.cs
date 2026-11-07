using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public interface IStokGozlemcisi
    {
        void StokKritikBildirimi(Modeller.UrunBileseni urun);
    }
}
