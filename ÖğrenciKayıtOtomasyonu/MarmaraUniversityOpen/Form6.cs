using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MarmaraUniversityOpen
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider= Microsoft.Jet.OLEDB.4.0;Data Source=Database201.mdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Tablo1 where tc='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'";
            OleDbDataReader dr = cmd.ExecuteReader();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                DialogResult bosyer = new DialogResult();
                bosyer = MessageBox.Show("Lütfen Boş Yer Bırakmayınız!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (dr.Read())
            {
                Form7 frm7=new Form7();
                frm7.Show();
                this.Hide();
            }

            else
            {
                DialogResult hata1 = new DialogResult();
                hata1 = MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }









        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
