using System;
using System.Collections.Generic; // For List
using System.Data;
using System.Data.SqlClient; // Required for SQL Server interaction
using System.Globalization; // For currency formatting
using System.Windows.Forms;
// using System.Configuration; // Use if storing connection string in App.config

namespace TicketVendorDemo
{
    public partial class Form1 : Form
    {

        private readonly string connectionString = "Server=LAPTOP-Q22SNUOQ;Database=TicketVendorDB;Integrated Security=True;"
; // MODIFY AS NEEDED

        // --- Helper Class for ComboBox Items ---
        private class DestinationItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            // This determines what text is shown in the ComboBox
            public override string ToString()
            {
                return Name;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // --- Load Destinations when Form Loads ---
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDestinations();
            lblOutputMessage.Text = "Please select a destination.";
        }

        private void LoadDestinations()
        {
            cmbDestinations.Items.Clear(); // Clear existing items if any
            var destinations = new List<DestinationItem>();
            string sqlQuery = "SELECT DestinationID, Name FROM Destinations ORDER BY Name;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                destinations.Add(new DestinationItem
                                {
                                    ID = Convert.ToInt32(reader["DestinationID"]),
                                    Name = reader["Name"].ToString()
                                });
                            }
                        } // Reader is disposed here
                    } // Command is disposed here
                } // Connection is disposed and closed here

                // Populate ComboBox
                cmbDestinations.DataSource = destinations; // Use data binding for simplicity
                cmbDestinations.DisplayMember = "Name";   // Property to display
                cmbDestinations.ValueMember = "ID";       // Property to use as the value
                cmbDestinations.SelectedIndex = -1; // No initial selection
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading destinations: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblOutputMessage.Text = "Error loading data.";
            }
        }

        // --- Update Fare when Destination Changes ---
        private void cmbDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestinations.SelectedItem is DestinationItem selectedDestination) // Check if a valid item is selected
            {
                string sqlQuery = "SELECT Fare FROM Destinations WHERE DestinationID = @DestinationID;";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            // Use parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@DestinationID", selectedDestination.ID);

                            connection.Open();
                            object result = command.ExecuteScalar(); // Efficient for single value

                            if (result != null && result != DBNull.Value)
                            {
                                decimal fare = Convert.ToDecimal(result);
                                // Format as currency using the system's current culture
                                lblFareDisplay.Text = fare.ToString("C", CultureInfo.CurrentCulture);
                                btnBuyTicket.Enabled = true; // Enable purchase button
                                lblOutputMessage.Text = "Ready to buy.";
                            }
                            else
                            {
                                lblFareDisplay.Text = "N/A";
                                btnBuyTicket.Enabled = false;
                                lblOutputMessage.Text = "Fare not found.";
                            }
                        } // Command disposed
                    } // Connection disposed
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching fare: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFareDisplay.Text = "Error";
                    btnBuyTicket.Enabled = false;
                    lblOutputMessage.Text = "Error fetching fare.";
                }
            }
            else
            {
                // No valid item selected, reset UI
                lblFareDisplay.Text = "0.00";
                btnBuyTicket.Enabled = false;
                lblOutputMessage.Text = "Please select a destination.";
            }
        }

        // --- Handle Buy Ticket Button Click ---
        private void btnBuyTicket_Click(object sender, EventArgs e)
        {

        }
    }
}