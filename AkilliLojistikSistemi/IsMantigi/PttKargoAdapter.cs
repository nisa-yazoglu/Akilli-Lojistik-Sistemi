using AkilliLojistikSistemi.DisSistemler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class PttKargoAdapter : IKargoServisi
    {
        private PttKargoAPI _pttApi;

        public PttKargoAdapter()
        {
            _pttApi = new PttKargoAPI();
        }

        public decimal FiyatHesapla(double agirlik, double mesafe)
        {
            int desi = Convert.ToInt32(agirlik);
            int kilometre = Convert.ToInt32(mesafe);

            int pttFiyat = _pttApi.UcretSorgula(desi, kilometre);

            return Convert.ToDecimal(pttFiyat);
        }

        public string TakipNoOlustur()
        {
            return _pttApi.BarkodUret();
        }
    }
}
