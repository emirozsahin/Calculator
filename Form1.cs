using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        int sayı1, sayı2;
        string kontrol;
        int sonuc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
                textBox1.Clear();
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            
        }

        private void islem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sayı1 = int.Parse(textBox1.Text);
            kontrol = btn.Text;
            textBox1.Clear();
            






        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sayı2 = int.Parse(textBox1.Text);
            if (kontrol == "+")
                sonuc = sayı1 + sayı2;
            else if (kontrol == "-")
                sonuc = sayı1 - sayı2;

            else if (kontrol == "/")
                sonuc = sayı1 / sayı2;
            else if (kontrol == "*")
                sonuc = sayı1 * sayı2;
            textBox1.Text = sonuc.ToString();
            sayı1 = sonuc;
            kontrol = "";

            


        }
    }
}
