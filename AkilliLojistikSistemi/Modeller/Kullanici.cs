using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.Modeller
{
    public enum KullaniciRolu
    {
        Admin,
        Personel,
        Musteri
    }

    public class Kullanici
    {
        public string Ad { get; set; }
        public KullaniciRolu Rol { get; set; }
    }
}
