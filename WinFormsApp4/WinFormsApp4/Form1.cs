using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace WinFormsApp4

{
    public partial class Form1 : Form
    {
        private int userID; // Store the UserID of the logged-in user

        public Form1(int loggedInUserID)
        {
            InitializeComponent();
            userID = loggedInUserID; // Set the logged-in user ID
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Collect the data from input form
            string complaintID = textBox2.Text;  // Example: Complaint ID from Customer ID TextBox
            string complaintDescription = "";  // Description

            if (radioButton1.Checked)
            {
                complaintDescription = "Slow Internet";
            }
            else if (radioButton2.Checked)
            {
                complaintDescription = "Network";
            }
            else if (radioButton3.Checked)
            {
                complaintDescription = "Network Outage";
            }

            if (string.IsNullOrEmpty(complaintDescription))
            {
                MessageBox.Show("Please select a complaint type.");
                return;
            }
            InsertComplaint(complaintID, complaintDescription);
            MessageBox.Show($"Complaint Submitted!\nID: {complaintID}\nCategory: {complaintDescription}");
            // After collecting the data, pass it to the OutputForm
            Form2 outputForm = new Form2(complaintID, complaintDescription);
            outputForm.Show();  // Show the Output Form
            this.Hide();        // Hide the current Input Form


        }
        private void InsertComplaint(string complaintID, string complaintDescription)
        {
            string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Complaints (ComplaintID, UserID, Description, Category, Status) " +
                               "VALUES (@ComplaintID, @UserID, @Description, @Category, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ComplaintID", complaintID);
                    command.Parameters.AddWithValue("@UserID", userID);  // Add UserID here
                    command.Parameters.AddWithValue("@Description", complaintDescription);
                    command.Parameters.AddWithValue("@Category", complaintDescription);
                    command.Parameters.AddWithValue("@Status", "Pending");

                    connection.Open();
                    command.ExecuteNonQuery();  // Execute the query to insert data
                    MessageBox.Show("Complaint submitted successfully!");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
