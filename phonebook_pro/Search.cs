using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phonebook_pro
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You Must Enter ID", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return;
            }
            //----------------------------------------
            string fn;
            fn = "C:\\tuts\\";
            string p;
            string r;
            //---------FirstName-----------------------
            p = fn + this.textBox1.Text + "_fn.txt";
            if(System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.FirstName_textBox2.Text = r;
            }
            //-------LastName---------------------------
            p = fn + this.textBox1.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.LastName_textBox3.Text = r;
            }
            //-------telephone--------------------------
            p = fn + this.textBox1.Text + "_tell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Telephone_textBox4.Text = r;
            }
            //-------cellphone---------------------------
            p = fn + this.textBox1.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.CellNumber_textBox5.Text = r;
            }
            //-------Email---------------------------
            p = fn + this.textBox1.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Email_textBox6.Text = r;
            }
            //-------Address---------------------------
            p = fn + this.textBox1.Text + "_add.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Addres_textBox7.Text = r;
            }
            //-------Comments---------------------------
            p = fn + this.textBox1.Text + "_com.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Comment_textBox8.Text = r;
            }
            //-------------------------------------------
            this.ID_textBox1.Text = this.textBox1.Text;
        }
    }
}
