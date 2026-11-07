using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.DisSistemler
{
    public class PttKargoAPI
    {
        public int UcretSorgula(int desi, int kilometre)
        {
            return 40 + (desi * 3) + (kilometre / 10);
        }

        public string BarkodUret()
        {
            return "PTT-" + new Random().Next(100000, 999999).ToString();
        }
    }
}
