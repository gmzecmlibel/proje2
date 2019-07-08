using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huray
{
    public partial class Form1 : Form
    {
        public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürünekle frm = new ürünekle();
            frm.Show();
            this.Hide();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürünsil urunsil = new ürünsil();
            urunsil.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
    }
}
