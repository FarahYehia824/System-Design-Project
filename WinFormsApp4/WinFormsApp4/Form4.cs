using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;


namespace WinFormsApp4
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True"; // Update with your DB connection
        public Form4()
        {
            InitializeComponent();
        }

        private void textBoxComplaintID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadComplaints();
            comboBox1.SelectedIndex = 0; // Set default value for status ComboBox, "Pending", "Investigating");
            comboBox1.SelectedIndex = 0; // Set default value
        }
        // Load complaints from the database into DataGridView
        private void LoadComplaints()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ComplaintID, Description, Category, Status, AdminComments FROM Complaints";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        // Update the complaint status and admin comments
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];

                // Check if the ComboBox has a selected item before accessing it
                if (comboBox1.SelectedItem != null)
                {
                    // Get values from TextBox and ComboBox
                    string complaintID = selectedRow.Cells["ComplaintID"].Value.ToString();
                    string adminComments = textBoxAdminComments.Text;
                    string status = comboBox1.SelectedItem.ToString();

                    // Update the database
                    UpdateComplaintStatus(complaintID, adminComments, status);

                    // Optionally save these changes to your database
                    MessageBox.Show("Complaint updated successfully!");

                    // Update the TextBox values after the update
                    textBoxComplaintID.Text = complaintID;
                    textBoxAdminComments.Text = adminComments;
                    comboBox1.SelectedItem = status;
                }
                else
                {
                    MessageBox.Show("Please select a status for the complaint.");
                }
            }
            else
            {
                MessageBox.Show("Please select a complaint first.");
            }
        }
        // Update complaint status and admin comments in the database
        private void UpdateComplaintStatus(string complaintID, string adminComments, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Complaints SET Status = @Status, AdminComments = @AdminComments WHERE ComplaintID = @ComplaintID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ComplaintID", complaintID);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@AdminComments", adminComments);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Populate TextBox and ComboBox with values from the selected row
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get values from the selected row
                textBoxComplaintID.Text = dataGridView1.Rows[e.RowIndex].Cells["ComplaintID"].Value.ToString();
                textBoxAdminComments.Text = dataGridView1.Rows[e.RowIndex].Cells["AdminComments"].Value.ToString();
                comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            }
        }

        private void textBoxAdminComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
