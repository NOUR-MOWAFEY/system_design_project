using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotel_system
{
    public partial class Client_Data : UserControl
    {
        SqlConnection conn;
        string strconn = "Data Source=NOURMOWAFEY;Initial Catalog=hotel_management;Integrated Security=True";

        public Book_Room BookRoomControl { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string RoomName { get; set; }

        public Client_Data()
        {
            InitializeComponent();
            gender_combobox.Items.AddRange(new string[] { "Male", "Female" });
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(full_name_textbox.Text) ||
                    string.IsNullOrWhiteSpace(phone_textbox.Text) ||
                    string.IsNullOrWhiteSpace(address_textbox.Text) ||
                    string.IsNullOrWhiteSpace(id_textbox.Text) ||
                    gender_combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int age = DateTime.Now.Year - dob_timepicker.Value.Year;
                if (dob_timepicker.Value > DateTime.Now.AddYears(-age)) age--;

                if (age < 18)
                {
                    MessageBox.Show("You must be at least 18 years old to book a room.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    conn.Open();

                    string checkRoomQuery = @"
                SELECT COUNT(*) 
                FROM customers
                WHERE room_name = @room_name 
                AND ((@date_from BETWEEN date_from AND date_to) OR (@date_to BETWEEN date_from AND date_to))";

                    using (SqlCommand checkRoomCmd = new SqlCommand(checkRoomQuery, conn))
                    {
                        checkRoomCmd.Parameters.AddWithValue("@room_name", this.RoomName);
                        checkRoomCmd.Parameters.AddWithValue("@date_from", this.DateFrom);
                        checkRoomCmd.Parameters.AddWithValue("@date_to", this.DateTo);

                        int bookedCount = (int)checkRoomCmd.ExecuteScalar();

                        if (bookedCount > 0)
                        {
                            MessageBox.Show("The room is already booked for the selected dates. Please choose another room or dates.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert customer data into the customers table
                    string query = @"
                INSERT INTO customers (client_id, full_name, phone_no, address, dob, gender, date_from, date_to, room_name)
                VALUES (@client_id, @full_name, @phone_no, @address, @dob, @gender, @date_from, @date_to, @room_name)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@client_id", int.Parse(id_textbox.Text));
                        cmd.Parameters.AddWithValue("@full_name", full_name_textbox.Text);
                        cmd.Parameters.AddWithValue("@phone_no", phone_textbox.Text);
                        cmd.Parameters.AddWithValue("@address", address_textbox.Text);
                        cmd.Parameters.AddWithValue("@dob", dob_timepicker.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", gender_combobox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@date_from", this.DateFrom);
                        cmd.Parameters.AddWithValue("@date_to", this.DateTo);
                        cmd.Parameters.AddWithValue("@room_name", this.RoomName);

                        cmd.ExecuteNonQuery();
                    }

                    // Update available_from in the rooms table
                    string updateRoomQuery = @"
                UPDATE rooms 
                SET available_from = DATEADD(DAY, 1, @date_to)
                WHERE room_name = @room_name";

                    using (SqlCommand updateRoomCmd = new SqlCommand(updateRoomQuery, conn))
                    {
                        updateRoomCmd.Parameters.AddWithValue("@date_to", this.DateTo);
                        updateRoomCmd.Parameters.AddWithValue("@room_name", this.RoomName);
                        updateRoomCmd.ExecuteNonQuery();
                    }

                    // Update available_from in rooms table
                    try
                    {
                        using (SqlConnection updateConn = new SqlConnection(strconn))
                        {
                            updateConn.Open();
                            string updateQuery = "UPDATE rooms SET available_from = @available_from WHERE room_id = @room_id";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, updateConn))
                            {
                                updateCmd.Parameters.AddWithValue("@available_from", BookRoomControl.ToDateSelected);
                                updateCmd.Parameters.AddWithValue("@room_id", RoomName);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Room availability updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating room availability: " + ex.Message);
                    }

                    MessageBox.Show("Customer booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear fields and refresh grid view in Book_Room
                    BookRoomControl.ClearFieldsAndRefreshGrid();

                    // Optionally, you can clear fields or make adjustments here
                    ClearFields();
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            full_name_textbox.Clear();
            phone_textbox.Clear();
            address_textbox.Clear();
            id_textbox.Clear();
            dob_timepicker.Value = DateTime.Now;
            gender_combobox.SelectedIndex = -1;
        }
    }
}
