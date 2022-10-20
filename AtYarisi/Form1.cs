using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random uzaklikRnd = new Random();
        Random wghtRnd = new Random();
        //timer başladığı zaman atlar rastgele bi sayıya göre hareket edicek.
        //picturebox ın sağının konumu label ın solunun konumuna değdiği zaman oyun bitecek
        //oyun bitişinde 1 2 3 .at kazandı yazısını ekrana gösterilecek(hangisi kazanırsa)
        private void tmrYaris_Tick(object sender, EventArgs e)
        {
            pb1.Left += uzaklikRnd.Next(1, 25);
            pb2.Left += uzaklikRnd.Next(1, 25);
            pb3.Left += uzaklikRnd.Next(1, 25);

            if(pb1.Right >= label1.Left)
            {
                tmrYaris.Stop();
                MessageBox.Show("Ahmet dayının atı kazandı.");
                pb1.Left = pb2.Left = pb3.Left = 0;
                btnBaslat.Enabled = true;
            }
            else if (pb2.Right >= label1.Left)
            {
                tmrYaris.Stop();
                MessageBox.Show("Ali dayının atı kazandı.");
                pb1.Left = pb2.Left = pb3.Left = 0;
                btnBaslat.Enabled = true;
            }
            else if (pb3.Right >= label1.Left)
            {
                tmrYaris.Stop();
                MessageBox.Show("Erol dayının atı kazandı.");
                pb1.Left = pb2.Left = pb3.Left = 0;
                btnBaslat.Enabled = true;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            tmrYaris.Start();
            btnBaslat.Enabled = false;
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
        }
    }
}
