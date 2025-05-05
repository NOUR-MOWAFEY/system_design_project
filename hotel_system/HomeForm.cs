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



namespace hotel_system
{
    public partial class HomeForm : KryptonForm
    {
        //DataSet ds = new DataSet();
        //SqlDataAdapter da;
        //SqlConnection con;

        public HomeForm()
        {
            InitializeComponent();
        }

        void showData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //admin_AddUser1.Visible = false;
            //admin_Rooms1.Visible = false;
            //string strConnection = "data source = NourMowafey; initial catalog = master; integrated security = true";
            //con = new SqlConnection(strConnection);
            //con.Open();
            //da = new SqlDataAdapter("select * from users", con);
            //SqlCommandBuilder cb = new SqlCommandBuilder(da);
            //da.Fill(ds, "users");
            //HomeForm homeForm = new HomeForm();
            //showData.DataSource = ds.Tables["users"];
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void rooms_button_Click(object sender, EventArgs e)
        {
            //admin_Rooms1.Visible = true;
            //admin_AddUser1.Visible = false;
        }

        private void users_button_Click(object sender, EventArgs e)
        {
            //admin_Rooms1.Visible = false;
            //admin_AddUser1.Visible = true;
        }
    }
}
