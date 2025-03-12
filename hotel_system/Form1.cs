using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace hotel_system
{
    public partial class Form1: KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void username_textbox_Enter(object sender, EventArgs e)
        {
            if (username_textbox.Text == "Username")
            {
                username_textbox.Text = "";
                username_textbox.ForeColor = Color.Black;
            }
        }

        private void username_textbox_Leave(object sender, EventArgs e)
        {
            if (username_textbox.Text == "") {
                username_textbox.Text = "Username";
                username_textbox.ForeColor = Color.Black;
            }
        }
        
        private void password_textbox_Enter(object sender, EventArgs e)
        {
            if (password_textbox.Text == "Password")
            {
                password_textbox.PasswordChar = '•';
                password_textbox.Text = "";
                password_textbox.ForeColor = Color.Black;
            }
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {

            if (password_textbox.Text == "")
            {
                password_textbox.PasswordChar = '\0';
                password_textbox.Text = "Password";
                password_textbox.ForeColor = Color.Black;
            }

        }

    }
}
