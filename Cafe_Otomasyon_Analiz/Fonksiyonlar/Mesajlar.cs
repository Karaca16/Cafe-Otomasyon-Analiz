using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomasyon_Analiz.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj,"Yeni Kayıt Girişi",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
