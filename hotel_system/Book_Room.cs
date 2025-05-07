using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_system
{
    public partial class Book_Room : UserControl
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        const string strconn = "Data Source=NOURMOWAFEY;Initial Catalog=hotel_management;Integrated Security=True";

        public Book_Room()
        {
            InitializeComponent();
        }

        // Public properties to safely access date pickers
        public DateTime ToDateSelected => toTimePicker.Value;
        public DateTime FromDateSelected => fromTimePicker.Value;

        private void Book_Room_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            RefreshRoomsGrid();
            rooms_grid_view.CellClick += rooms_grid_view_CellClick;
        }

        public void RefreshRoomsGrid()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT * FROM rooms";
                da = new SqlDataAdapter(query, conn);
                ds.Tables.Clear();
                da.Fill(ds, "rooms");
                rooms_grid_view.DataSource = ds.Tables["rooms"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
        }

        private void rooms_grid_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = rooms_grid_view.Rows[e.RowIndex];

                roomID.Text = row.Cells["room_id"].Value.ToString();
                roomView.Text = row.Cells["room_view"].Value.ToString();
                roomBedsNo.Text = row.Cells["room_beds_no"].Value.ToString();
                roomSize.Text = row.Cells["room_size"].Value.ToString();
                roomStatus.Text = row.Cells["room_status"].Value.ToString();
                roomPrice.Text = row.Cells["room_price"].Value.ToString();
            }
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = fromTimePicker.Value;
                DateTime toDate = toTimePicker.Value;

                if (toDate <= fromDate)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
                    SELECT COUNT(*) 
                    FROM customers
                    WHERE room_name = @room_name
                    AND ((@date_from BETWEEN date_from AND date_to) OR (@date_to BETWEEN date_from AND date_to))";

                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@room_name", roomID.Text);
                        cmd.Parameters.AddWithValue("@date_from", fromDate);
                        cmd.Parameters.AddWithValue("@date_to", toDate);

                        int bookedCount = (int)cmd.ExecuteScalar();

                        if (bookedCount > 0)
                        {
                            MessageBox.Show("The room is already booked for the selected dates. Please choose another room or dates.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                int totalDays = (toDate - fromDate).Days;
                float dailyPrice = float.Parse(roomPrice.Text);
                float total = totalDays * dailyPrice;

                total_price.Text = total.ToString("0.00") + " EGP";

                client_Data1.DateFrom = fromDate;
                client_Data1.DateTo = toDate;
                client_Data1.RoomName = roomID.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking room availability: " + ex.Message);
            }
        }

        private void book_room_button_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fromTimePicker.Value;
            DateTime toDate = toTimePicker.Value;

            client_Data1.BookRoomControl = this;

            if (toDate <= fromDate)
            {
                MessageBox.Show("Please choose a valid check-in and check-out date before booking.", "Missing Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(roomID.Text))
            {
                MessageBox.Show("Please select a room before booking.", "Missing Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            client_Data1.Visible = true;
            client_Data1.BringToFront();
        }

        public void ClearFieldsAndRefreshGrid()
        {
            roomID.Text = "--------";
            roomView.Text = "--------";
            roomBedsNo.Text = "--------";
            roomSize.Text = "--------";
            roomStatus.Text = "--------";
            roomPrice.Text = "--------";
            total_price.Text = "--------";
            toTimePicker.Value = DateTime.Now;
            fromTimePicker.Value = DateTime.Now;
            RefreshRoomsGrid();
        }
    }
}
