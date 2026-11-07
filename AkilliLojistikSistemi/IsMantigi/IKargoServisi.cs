using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public interface IKargoServisi
    {
        string TakipNoOlustur();
        decimal FiyatHesapla(double agirlik, double mesafe);
    }
}
