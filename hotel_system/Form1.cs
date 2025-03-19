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
using System.Data.SqlClient;

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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            HomeForm homeForm1 = new HomeForm();
            homeForm1.Show();
            this.Hide();
            //SqlCommand("", con);
            //SignForm signForm = new SignForm();
            //signForm.Show();
            //this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.Show();
            this.Hide();
        }
    }
}
