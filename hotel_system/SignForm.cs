using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hotel_system
{
    public partial class SignForm: KryptonForm
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;

        public SignForm()
        {
            InitializeComponent();
            label1.Select();
        }

        private void SignForm_Load(object sender, EventArgs e)
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

        private void confirm_password_Enter(object sender, EventArgs e)
        {
            if (confirm_password.Text == "Confirm Password")
            {
                confirm_password.PasswordChar = '•';
                confirm_password.Text = "";
                confirm_password.ForeColor = Color.Black;
            }
        }

        private void confirm_password_Leave(object sender, EventArgs e)
        {
            if (confirm_password.Text == "")
            {
                confirm_password.PasswordChar = '\0';
                confirm_password.Text = "Confirm Password";
                confirm_password.ForeColor = Color.Black;
            }
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void SignForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signin_button_Click_1(object sender, EventArgs e)
        {

            if (username_textbox.Text == "Username" || password_textbox.Text == "Password" || confirm_password.Text == "Confirm Password")
            {
                MessageBox.Show("All Fields must be filled in", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (username_textbox.Text.Length <= 4 || username_textbox.Text.Any(char.IsLetter) == false || password_textbox.Text.Length <= 4)
            {
                MessageBox.Show("Username and password must have more than 5 characters and username must have atleast one letter", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                if (password_textbox.Text == confirm_password.Text) 
                {
                    string checkQuery = "SELECT username FROM users WHERE username = @username";

                    using (SqlCommand checkUsername = new SqlCommand(checkQuery, conn))
                    {
                        checkUsername.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                        da = new SqlDataAdapter(checkUsername);
                        DataTable table = new DataTable();
                        da.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(username_textbox.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertQuery = "insert into users(username, password) values(@username, @password)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", password_textbox.Text.Trim());

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("User Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginForm form1 = new LoginForm();
                                form1.Show();
                                this.Hide();

                            }
                        }
                    }
                
                }
                else
                {
                    MessageBox.Show("Password does not match with confirm field", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

            
        }
    }
    }

