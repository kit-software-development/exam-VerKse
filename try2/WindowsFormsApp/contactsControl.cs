using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class contactsControl : UserControl
    {
        public int ContactId { get; set; }

        public contactsControl(int ContactId, string firstName, string surname, string phone1, string phone2, string info)
        {
            InitializeComponent();
            this.ContactId = ContactId;
            this.firstName.Text = firstName;
            this.surname.Text = surname;
            this.phone1.Text = phone1;
            this.phone2.Text = phone2;
            this.info.Text = info;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(firstName.Text, surname.Text, phone1.Text, phone2.Text, info.Text);
            form2.Show();

        }
    }
}
