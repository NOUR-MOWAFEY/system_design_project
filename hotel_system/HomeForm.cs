using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace hotel_system
{
    public partial class HomeForm : KryptonForm
    {
        public string LoggedInUserRole { get; set; }

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            book_Room1.Visible = true;
            admin_Rooms1.Visible = false;
            admin_AddUser1.Visible = false;
            customers1.Visible = false;
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Rooms_button_Click(object sender, EventArgs e)
        {
            if (LoggedInUserRole != "admin")
            {
                MessageBox.Show("Access denied. This section is for Admins only.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            admin_Rooms1.RefreshUserGrid();
            book_Room1.Visible = false;
            admin_Rooms1.Visible = true;
            admin_AddUser1.Visible = false;
            customers1.Visible = false;
        }

        private void Users_button_Click(object sender, EventArgs e)
        {
            if (LoggedInUserRole != "admin")
            {
                MessageBox.Show("Access denied. This section is for Admins only.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            admin_AddUser1.RefreshUserGrid();
            book_Room1.Visible = false;
            admin_Rooms1.Visible = false;
            admin_AddUser1.Visible = true;
            customers1.Visible = false;
        }

        private void Book_button_Click(object sender, EventArgs e)
        {
            book_Room1.RefreshRoomsGrid();
            book_Room1.Visible = true;
            admin_Rooms1.Visible = false;
            admin_AddUser1.Visible = false;
            customers1.Visible = false;
        }

        private void Customers_button_Click(object sender, EventArgs e)
        {
            customers1.RefreshCustomersGrid();
            book_Room1.Visible = false;
            admin_Rooms1.Visible = false;
            admin_AddUser1.Visible = false;
            customers1.Visible = true;
        }
    }
}
