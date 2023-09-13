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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("Öğrenciler Personel Girişine Giremez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (asd == DialogResult.OK)
            {
                
                        Form2 form1 = new Form2();
                        form1.Show();
                        this.Hide();
            }
             




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}
