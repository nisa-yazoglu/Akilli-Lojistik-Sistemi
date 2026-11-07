using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliLojistikSistemi.VeriErisim
{
    public class Log_Servisi
    {
        private static Log_Servisi _ornek;

        private Log_Servisi() { }

        public static Log_Servisi Ornek
        {
            get
            {
                if (_ornek == null)
                {
                    _ornek = new Log_Servisi();
                }
                return _ornek;
            }
        }

        public System.Windows.Forms.ListBox ArayuzLogKutusu { get; set; }

        public void LogKaydet(string mesaj, ListBox lstKutu = null)
        {
            string logMetni = $"[{System.DateTime.Now.ToShortTimeString()}] {mesaj}";

            System.Diagnostics.Debug.WriteLine(logMetni);

            if (lstKutu != null)
            {
                lstKutu.Items.Add(logMetni);
                lstKutu.TopIndex = lstKutu.Items.Count - 1;
            }

            if (ArayuzLogKutusu != null)
            {
                ArayuzLogKutusu.Items.Add(mesaj);

                ArayuzLogKutusu.SelectedIndex = ArayuzLogKutusu.Items.Count - 1;
                ArayuzLogKutusu.ClearSelected();
            }
        }
    }
}
