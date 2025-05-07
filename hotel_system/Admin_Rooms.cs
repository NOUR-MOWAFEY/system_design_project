using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_system
{
    public partial class Admin_Rooms : UserControl
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;

        string strconn = "Data Source=NOURMOWAFEY;Initial Catalog=hotel_management;Integrated Security=True";

        public Admin_Rooms()
        {
            InitializeComponent();
        }

        private void Admin_Rooms_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            conn.Open();
            RefreshUserGrid();
        }

        public void RefreshUserGrid()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            string query = "SELECT * FROM rooms";
            da = new SqlDataAdapter(query, conn);
            ds.Tables.Clear();
            da.Fill(ds, "rooms");
            users_grid_view.DataSource = ds.Tables["rooms"];
        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(room_name_textbox.Text) ||
                string.IsNullOrEmpty(room_bed_textbox.Text) ||
                string.IsNullOrEmpty(room_view_textbox.Text) ||
                string.IsNullOrEmpty(room_size_textbox.Text) ||
                string.IsNullOrEmpty(room_price_textbox.Text))
                return true;
            else
                return false;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("All fields must be filled in", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!int.TryParse(room_bed_textbox.Text.Trim(), out int roomBedsNo))
                {
                    MessageBox.Show("Room Beds Number must be a valid number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!float.TryParse(room_price_textbox.Text.Trim(), out float roomPrice))
                {
                    MessageBox.Show("Room Price must be a valid number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string checkRoomID = "SELECT room_name FROM rooms WHERE room_name = @roomName";
                    using (SqlCommand checkRID = new SqlCommand(checkRoomID, conn))
                    {
                        checkRID.Parameters.AddWithValue("@roomName", room_name_textbox.Text.Trim());

                        DataTable table = new DataTable();
                        da = new SqlDataAdapter(checkRID);
                        da.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(room_name_textbox.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string insertData = "INSERT INTO rooms (room_name, room_beds_no, room_view, room_size, room_price) " +
                                                "VALUES (@roomName, @roomBedsNo, @roomView, @roomSize, @roomPrice)";

                            using (SqlCommand cmd = new SqlCommand(insertData, conn))
                            {
                                cmd.Parameters.AddWithValue("@roomName", room_name_textbox.Text.Trim());
                                cmd.Parameters.AddWithValue("@roomBedsNo", roomBedsNo);
                                cmd.Parameters.AddWithValue("@roomView", room_view_textbox.Text.Trim());
                                cmd.Parameters.AddWithValue("@roomSize", room_size_textbox.Text.Trim());
                                cmd.Parameters.AddWithValue("@roomPrice", roomPrice);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Room added successfully!");

                                RefreshUserGrid();
                                ClearFields();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(room_name_textbox.Text.Trim()))
            {
                MessageBox.Show("Please enter the room name to delete.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string checkRoomQuery = "SELECT room_name FROM rooms WHERE room_name = @roomName";
                    using (SqlCommand checkRoomCmd = new SqlCommand(checkRoomQuery, conn))
                    {
                        checkRoomCmd.Parameters.AddWithValue("@roomName", room_name_textbox.Text.Trim());

                        DataTable table = new DataTable();
                        da = new SqlDataAdapter(checkRoomCmd);
                        da.Fill(table);

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("The room with this name does not exist.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string deleteQuery = "DELETE FROM rooms WHERE room_name = @roomName";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@roomName", room_name_textbox.Text.Trim());
                                deleteCmd.ExecuteNonQuery();
                                MessageBox.Show("Room deleted successfully!");

                                RefreshUserGrid();
                                ClearFields();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            room_name_textbox.Clear();
            room_bed_textbox.Clear();
            room_view_textbox.Clear();
            room_size_textbox.Clear();
            room_price_textbox.Clear();
            room_name_textbox.Focus();
        }
    }
}
