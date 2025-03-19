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
    public partial class SignForm: KryptonForm
    {

        public SignForm()
        {
            InitializeComponent();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {

        }

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
            if (username_textbox.Text == "")
            {
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void SignForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
