using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phonebook_pro
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            this.New_Button.Enabled = false;
            this.Save_Button.Enabled = true;
            //------------------------------
            this.Info_group_box.Enabled = true;
            //------------Clear TextBoxes------------------
            //---------------------------------------------
            this.ID_textBox1.ResetText();
            this.FirstName_textBox2.ResetText();
            this.LastName_textBox3.ResetText();
            this.Telephone_textBox4.ResetText();
            this.CellNumber_textBox5.ResetText();
            this.Email_textBox6.ResetText();
            this.Addres_textBox7.ResetText();
            this.Comment_textBox8.ResetText();
            //---------------------------------------------

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (this.ID_textBox1.Text == "")
            {
                MessageBox.Show("You Must Enter ID", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return;
            }
            this.Save_Button.Enabled = false;
            this.New_Button.Enabled = true;
            //------------------------------
            this.Info_group_box.Enabled = false;
            //----------------------------------
            string fn;
            fn = "C:\\tuts\\";
            string p;
            //---------FirstName-----------------------
            p = fn + this.ID_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.FirstName_textBox2.Text, Encoding.UTF8);
            //------------LastName---------------------
            p = fn + this.ID_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.LastName_textBox3.Text, Encoding.UTF8);
            //------------Telephone--------------------
            p = fn + this.ID_textBox1.Text + "_tell.txt";
            System.IO.File.WriteAllText(p, this.Telephone_textBox4.Text, Encoding.UTF8);
            //-------------CellPhone-------------------
            p = fn + this.ID_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.CellNumber_textBox5.Text, Encoding.UTF8);
            //-------------Email-----------------------
            p = fn + this.ID_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.Email_textBox6.Text, Encoding.UTF8);
            //-------------Address---------------------
            p = fn + this.ID_textBox1.Text + "_add.txt";
            System.IO.File.WriteAllText(p, this.Addres_textBox7.Text, Encoding.UTF8);
            //-------------Comment---------------------
            p = fn + this.ID_textBox1.Text + "_com.txt";
            System.IO.File.WriteAllText(p, this.Comment_textBox8.Text, Encoding.UTF8);
            //-----------------------------------------
            MessageBox.Show("Save Successful!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.Info_group_box.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
