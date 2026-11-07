using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public interface ISistemIslemleri
    {
        void StokGuncelle(string urunAdi, int miktar);
        void SiparisVer();
    }
}
