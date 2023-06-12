using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen İndirmek İstediğiniz Oyunu Seçiniz..");
        }
        string secilenoyun;
        private void button1indir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                secilenoyun = "CounterStrike";
            }
            if (radioButton2.Checked)
            {
                secilenoyun = "Euro Truck Simulator 2";
            }
            if (radioButton3.Checked)
            {
                secilenoyun = "GTA V";
            }
            if (radioButton4.Checked)
            {
                secilenoyun = "Minecraft";
            }
            Form2 frm2= new Form2();
            frm2.ShowDialog();
        }
    }
}
