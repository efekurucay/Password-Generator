using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreolusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_uzunluk_Scroll(object sender, EventArgs e)
        {
            lbl_uzunluk.Text = tb_uzunluk.Value.ToString();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = String.Empty;
            Random rnd = new Random();

            if (chk_buyukharf.Checked == false && chk_kucukharf.Checked==false&& chk_rakam.Checked==false&&chk_ozelkarakter.Checked==false)
            {
                MessageBox.Show("Bütün kutucuklar boş olamaz!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string buyukharfhavuz = "QWERTYUIOPASDFGHJKLZXCVBNM";
                string kucukharfhavuz = "qwertyuopasdfghjklizxcvbnm";
                string rakamhavuz = "0123456789";
                string ozelhavuz = "?/+%&!^.;*-_";
                string sifre = "";
                if (chk_buyukharf.Checked) { sifre += buyukharfhavuz; }
                if (chk_kucukharf.Checked) { sifre += kucukharfhavuz; }
                if (chk_rakam.Checked) { sifre += rakamhavuz; }
                if (chk_ozelkarakter.Checked) { sifre += ozelhavuz; }


                for (int i = 0; i < tb_uzunluk.Value; i++)
                { txt_sifre.Text += sifre[rnd.Next(sifre.Length)]; }
            }
           

            

        }
    }
}
