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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = Convert.ToString(textBox7.Text);
            string sifret = Convert.ToString(textBox8.Text);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database201.mdb");
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Tablo2 where kulad='" + textBox5.Text + "'and kulsifre='" + textBox6.Text + "'";
            OleDbDataReader dr = cmd.ExecuteReader();
            if (textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                DialogResult asd = new DialogResult();
                asd = MessageBox.Show("Lütfen Boş Yer Bırakmayınız", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sifre != sifret)
            {
                DialogResult das = new DialogResult();
                das = MessageBox.Show("Şifreler Uyuşmuyor", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (dr.Read())
            {
                DialogResult nesne = new DialogResult();
                nesne = MessageBox.Show("Şifre Değiştirilsin Mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (nesne == DialogResult.Yes)
                {
                    con = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Database201.mdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update Tablo2 set kulsifre='" + textBox7.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult sifredegistirme = new DialogResult();
                    sifredegistirme = MessageBox.Show("Şifreniz Başarıyla Değiştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form2 frm1 = new Form2();
                    frm1.Show();
                    this.Hide();
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                }
                else if (nesne == DialogResult.No)
                {
                    DialogResult sifredegistirme = new DialogResult();
                    sifredegistirme = MessageBox.Show("Şifre Değiştirilmedi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult sifredegistirme = new DialogResult();
                sifredegistirme = MessageBox.Show("Girmiş Olduğunuz Bilgiler Hatalı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }






        }
    }
}
