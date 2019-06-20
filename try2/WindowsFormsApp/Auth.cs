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
    public partial class Auth : Form
    {
        
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void Phone1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            Program.SendMessage(textBoxLoggin+"|"+textBoxPassword+  "4");
            if (Program.ReceiveMessage() == "true")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else { textBoxPassword.BackColor = Color.Red; }

        }

        private void TextBoxpassword_TextChanged(object sender, EventArgs e)
        {
          
        }

     
    }
}
