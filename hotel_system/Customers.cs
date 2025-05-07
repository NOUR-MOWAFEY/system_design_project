using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_system
{
    public partial class Customers : UserControl
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dt;

        private const string strconn = "Data Source=NOURMOWAFEY;Initial Catalog=hotel_management;Integrated Security=True";

        public Customers()
        {
            InitializeComponent();
            conn = new SqlConnection(strconn);
            this.Load += Customers_Load;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            RefreshCustomersGrid();
        }

        public void RefreshCustomersGrid()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT * FROM customers";
                da = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                customers_grid_view.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
