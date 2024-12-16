using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        private string complaintID;
        private string complaintDescription;
        public Form2(string complaintID, string complaintDescription)
        {
            InitializeComponent();
            this.complaintID = complaintID;
            this.complaintDescription = complaintDescription;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FetchComplaintData(complaintID);
        }
        private void FetchComplaintData(string complaintID)
        {
            string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Description, Category, Status FROM Complaints WHERE ComplaintID = @ComplaintID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ComplaintID", complaintID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label1.Text = "Complaint ID: " + complaintID;
                        label2.Text = "Status: " + reader["Status"].ToString();
                        label3.Text = "Category: " + reader["Category"].ToString();
                        textBox1.Text = "Admin Comments: N/A";  // Static for now
                    }
                    else
                    {
                        MessageBox.Show("Complaint not found.");
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string updatedStatus = "In Progress";
            string adminComments = textBox1.Text;

            UpdateComplaintStatus(complaintID, updatedStatus, adminComments);

            //MessageBox.Show("Complaint status updated successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void UpdateComplaintStatus(string complaintID, string status, string adminComments)
        {
            string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";
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
                    MessageBox.Show("Complaint status updated successfully!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
