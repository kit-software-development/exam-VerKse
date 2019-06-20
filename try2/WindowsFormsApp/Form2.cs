using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2(string name, string surname, string phone1, string phone2, string info)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxSurname.Text = surname;
            textBoxPhone1.Text = phone1;
            textBoxPhone2.Text = phone2;
            textBoxInfo.Text = info;

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Info_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // передача данных 
            string message = textBoxName.Text + "|" + textBoxSurname.Text + "|" + textBoxPhone1.Text + "|" + textBoxPhone2.Text + "|" + textBoxInfo.Text + "2";
            Program.SendMessage(message);
            this.Hide();
            Form1 form1 = new Form1();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //delete
            string message = textBoxName.Text + "|" + textBoxSurname.Text + "|" + textBoxPhone1.Text + "|" + textBoxPhone2.Text + "|" + textBoxInfo.Text + "3";
            Program.SendMessage(message);
        }
    }
}
