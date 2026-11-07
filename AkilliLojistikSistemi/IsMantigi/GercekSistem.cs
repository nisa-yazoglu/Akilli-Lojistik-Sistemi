using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.IsMantigi
{
    public class GercekSistem : ISistemIslemleri
    {
        public void StokGuncelle(string urunAdi, int miktar)
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet($"{urunAdi} stoğu başarıyla {miktar} olarak güncellendi.");
        }

        public void SiparisVer()
        {
            VeriErisim.Log_Servisi.Ornek.LogKaydet("Sistem üzerinden yeni bir sipariş alındı.");
        }
    }
}
