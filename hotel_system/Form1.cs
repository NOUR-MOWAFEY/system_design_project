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

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            mainText.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strconn = "Data Source=NOURMOWAFEY;Initial Catalog=hotel_management;Integrated Security=True";
            conn = new SqlConnection(strconn);
            conn.Open();
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
            string username, password;

            username = username_textbox.Text;
            password = password_textbox.Text;

            if(username_textbox.Text == "Username" || password_textbox.Text == "Password") 
            {
                MessageBox.Show("All Fields must be filled in", "Information Message" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {


                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username_textbox.Text);
                cmd.Parameters.AddWithValue("@password", password_textbox.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    HomeForm homeForm1 = new HomeForm();
                    homeForm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.Show();
            this.Hide();
        }
    }
}
