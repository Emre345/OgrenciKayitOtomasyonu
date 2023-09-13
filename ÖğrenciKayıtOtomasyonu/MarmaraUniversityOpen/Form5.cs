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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database201.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
      

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Length < 12 && textBox6.Text.Length > 10)
            {
                if(textBox3.Text==textBox7.Text)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox3.Text != "")
                    {
                        if (checkBox2.Checked)
                        {
                            
                            DialogResult asd = new DialogResult();
                            asd = MessageBox.Show("Kayıt Yapılsın Mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (asd == DialogResult.Yes)
                            {

                                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database201.mdb");
                                OleDbCommand cmd = new OleDbCommand();
                                con.Open();
                                cmd.Connection = con;
                                cmd.CommandText = "Insert into Tablo1 (ogr_adi,ogr_soyadi,baba_adi,dogum_tarihi,sifre,tc) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "')";
                                cmd.ExecuteNonQuery();
                                con.Close();
                                DialogResult kayıt = new DialogResult();
                                kayıt = MessageBox.Show("Kaydınız Oluşturuldu!", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox1.Text = "";
                                textBox2.Text = "";

                                textBox4.Text = "";
                                dateTimePicker1.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                textBox3.Text = "";
                                Form6 frm6=new Form6();
                                frm6.Show();
                                this.Hide();

                            }



                            else if (asd == DialogResult.No)
                            {
                                DialogResult boş = new DialogResult();
                                boş = MessageBox.Show("Kayıt Yapılmadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            DialogResult sec = new DialogResult();
                            sec = MessageBox.Show("Lütfen Okudum, Onaylıyorum Kutucuğunu İşaretleyiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DialogResult error = new DialogResult();
                        error = MessageBox.Show("Lütfen Tüm Bilgileri Doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {

                    DialogResult hata = new DialogResult();
                    hata = MessageBox.Show("Şifreler Uyuşmuyor!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                DialogResult tc = new DialogResult();
                tc = MessageBox.Show("TC Numarası 11 Haneli Olmalıdır!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox6.MaxLength = 11;
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

      

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = '\0';
                textBox7.PasswordChar = '\0';

            }
            else
            {
                textBox3.PasswordChar = '*';
                textBox7.PasswordChar = '*';

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            
            if (richTextBox1.Visible)
            {
                richTextBox1.Visible = false;
               
            } 
            else
                {
                    richTextBox1.Visible = true;
                    
                }
        }
            
        

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        

      

    }
}
