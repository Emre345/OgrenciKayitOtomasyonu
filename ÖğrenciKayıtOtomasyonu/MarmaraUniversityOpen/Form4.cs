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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
     

       OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database201.mdb");
    OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
       
            void listele()
        {

            da = new OleDbDataAdapter("Select*from Tablo1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    DialogResult asd = new DialogResult();
                    asd = MessageBox.Show("Bilgiler Güncellensin Mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (asd == DialogResult.Yes)
                    {
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Database201.mdb");
                        OleDbCommand cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "update Tablo1 set ogr_adi='" + textBox1.Text + "' , ogr_soyadi='" + textBox2.Text + "', baba_adi='" + textBox4.Text + "', dogum_tarihi='" + textBox5.Text + "',sifre='"+textBox9.Text+"' where tc='" + textBox6.Text + "' ";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        listele();



                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox9.Text = "";
                    }
                    else
                    {
                        DialogResult cdf = new DialogResult();
                        cdf = MessageBox.Show("Güncellenmedi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                   
                }
                       else
                    {
                        DialogResult asdfg = new DialogResult();
                        asdfg = MessageBox.Show("Güncellenecek Kişi Seçili Değil!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

            }
         


         







        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = this.BackColor;
            listele();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
            DialogResult silme = new DialogResult();
            silme = MessageBox.Show("Öğrenci Silinsin Mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silme == DialogResult.Yes)
            {
                
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from Tablo1 where tc=+'" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    listele();


                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            
                else
                {
                    DialogResult siliş = new DialogResult();
                    siliş = MessageBox.Show("Öğrenci Silinmedi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                DialogResult silinmedi = new DialogResult();
                silinmedi = MessageBox.Show("Silinecek Öğrenci Seçili Değil!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("Select * from Tablo1 where ogr_adi Like '" + textBox7.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tablo1");
            con.Close();
            dataGridView1.DataSource = ds.Tables["Tablo1"];



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 FRM2 = new Form2();
            FRM2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 FRM2 = new Form1();
            FRM2.Show();
            this.Hide();
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
        
    }
}
