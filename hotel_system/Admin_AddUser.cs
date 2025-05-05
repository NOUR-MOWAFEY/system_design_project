using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_system
{
    public partial class Admin_AddUser : UserControl
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;
        string strconn = "Data Source=NOURMOWAFEY;Initial Catalog=hotel_management;Integrated Security=True";

        public Admin_AddUser()
        {
            InitializeComponent();
        }

        private void Admin_AddUser_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            conn.Open();
            RefreshUserGrid();
        }

        private void RefreshUserGrid()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string query = "SELECT * FROM users";
            da = new SqlDataAdapter(query, conn);
            ds.Tables.Clear();
            da.Fill(ds, "users");
            users_grid_view.DataSource = ds.Tables["users"];
        }

        private bool ValidateInput(out string username, out string password)
        {
            username = username_textbox.Text.Trim();
            password = password_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled in", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (username.Length <= 4 || !username.Any(char.IsLetter) || password.Length <= 4)
            {
                MessageBox.Show("Username and password must have more than 5 characters and username must have at least one letter", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool UserExists(string username)
        {
            string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@username", username);
                return (int)checkCmd.ExecuteScalar() > 0;
            }
        }

        private void AddUser(string role)
        {
            if (!ValidateInput(out string username, out string password))
                return;

            if (UserExists(username))
            {
                MessageBox.Show(username + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string insertQuery = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
            {
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@role", role);
                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("User Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            username_textbox.Clear();
            password_textbox.Clear();
            RefreshUserGrid();
        }

        private void add_normal_user_button_Click(object sender, EventArgs e)
        {
            AddUser("user");
        }

        private void add_admin_user_button_Click(object sender, EventArgs e)
        {
            AddUser("admin");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username must be filled in", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!UserExists(username))
            {
                MessageBox.Show("User does not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string deleteQuery = "DELETE FROM users WHERE username = @username";
            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            username_textbox.Clear();
            password_textbox.Clear();
            RefreshUserGrid();
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
