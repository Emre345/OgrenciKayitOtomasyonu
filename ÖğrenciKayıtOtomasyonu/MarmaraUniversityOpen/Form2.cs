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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                OleDbConnection con=new OleDbConnection("Provider= Microsoft.Jet.OLEDB.4.0;Data Source=Database201.mdb");
                OleDbCommand cmd=new OleDbCommand();
                con.Open();
                cmd.Connection=con;
                cmd.CommandText="Select * from Tablo2 where kulad='"+textBox1.Text+"' and kulsifre='"+textBox2.Text+"'";
                OleDbDataReader dr=cmd.ExecuteReader();
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    DialogResult bos = new DialogResult();
                    bos= MessageBox.Show("Lütfen Boş Yer Bırakmayınız!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dr.Read())
                {
                    Form4 frm3 = new Form4();
                    frm3.Show();
                    this.Hide();

                }
                else
                {
                    DialogResult hata = new DialogResult();
                    hata = MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }





                      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';

            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }
    }
}
