using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huray
{
    public partial class ürünekle : Form
    {

      //  Database1Entities uni = new Database1Entities();
        // public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\qmzec\OneDrive\Belgeler\visual studio 2013\Projects\huray\huray\Database1.mdf;Integrated Security=True";        
        public ürünekle()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ürünekle_Load(object sender, EventArgs e)
        {
         SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\qmzec\OneDrive\Belgeler\visual studio 2013\Projects\huray\huray\Database1.mdf;Integrated Security=True"); 
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into urunler values ('cat_id,cat_name,mus_id");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox2.Text == "" )
            MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ "); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
