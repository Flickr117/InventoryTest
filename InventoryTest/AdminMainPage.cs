using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class AdminMainPage : Form
    {
        private static string ConnectionString { get; } = $"Data Source={Path.Combine(Application.StartupPath, "Database", "inventory.db")};Version=3;";

        public AdminMainPage()
        {
            InitializeComponent();
        }

        // Method to manage stock items
        private void ManageStockItems()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name, Quantity FROM Inventory";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int i = 1;
                            while (reader.Read())
                            {
                                int stockId = reader.GetInt32(0);  // Get ID
                                string stockName = reader.GetString(1);  // Get Name
                                int quantity = reader.GetInt32(2);  // Get Quantity

                                // Display the stock data in designated text boxes
                                switch (i)
                                {
                                    case 1:
                                        StockItem1.Text = stockName;
                                        Quantity1.Text = quantity.ToString();
                                        break;
                                    case 2:
                                        StockItem2.Text = stockName;
                                        Quantity2.Text = quantity.ToString();
                                        break;
                                    case 3:
                                        StockItem3.Text = stockName;
                                        Quantity3.Text = quantity.ToString();
                                        break;
                                    case 4:
                                        StockItem4.Text = stockName;
                                        Quantity4.Text = quantity.ToString();
                                        break;
                                    case 5:
                                        StockItem5.Text = stockName;
                                        Quantity5.Text = quantity.ToString();
                                        break;
                                    case 6:
                                        StockItem6.Text = stockName;
                                        Quantity6.Text = quantity.ToString();
                                        break;
                                    case 7:
                                        StockItem7.Text = stockName;
                                        Quantity7.Text = quantity.ToString();
                                        break;
                                    default:
                                        break;
                                }
                                i++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No stock data found.");
                        }
                    }
                }
            }
        }

        // Method to update stock items in the database
        private void UpdateStockItem(int stockId, string newStockName, int newQuantity)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Inventory SET Name = @Name, Quantity = @Quantity WHERE Id = @StockId";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", newStockName);
                    cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                    cmd.Parameters.AddWithValue("@StockId", stockId);

                    cmd.ExecuteNonQuery();  // Execute without showing a message box
                    ManageStockItems();  // Reload the data to reflect changes in the UI
                }
            }
        }

        // Event handler for quantity or name text change
        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int stockId = 0;
                string newStockName = "";
                int newQuantity = 0;

                // Determine which stock item is being edited
                switch (textBox.Name)
                {
                    case "Quantity1":
                        stockId = 1;
                        newStockName = StockItem1.Text;  // Get name from corresponding stock item text box
                        break;
                    case "Quantity2":
                        stockId = 2;
                        newStockName = StockItem2.Text;
                        break;
                    case "Quantity3":
                        stockId = 3;
                        newStockName = StockItem3.Text;
                        break;
                    case "Quantity4":
                        stockId = 4;
                        newStockName = StockItem4.Text;
                        break;
                    case "Quantity5":
                        stockId = 5;
                        newStockName = StockItem5.Text;
                        break;
                    case "Quantity6":
                        stockId = 6;
                        newStockName = StockItem6.Text;
                        break;
                    case "Quantity7":
                        stockId = 7;
                        newStockName = StockItem7.Text;
                        break;
                }

                // Try to parse the quantity and update
                if (int.TryParse(textBox.Text.Trim(), out newQuantity) && stockId != 0)
                {
                    // If either the quantity or item name changes, update the stock item
                    UpdateStockItem(stockId, newStockName, newQuantity);
                }
                else
                {
                    MessageBox.Show("Invalid quantity or stock item.");
                }
            }
        }

        // Event handler for item name text change
        private void StockItemTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int stockId = 0;
                string newStockName = textBox.Text.Trim();  // Get the new name directly from the text box
                int newQuantity = 0;

                // Determine which stock item is being edited
                switch (textBox.Name)
                {
                    case "StockItem1":
                        stockId = 1;
                        newQuantity = int.TryParse(Quantity1.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                    case "StockItem2":
                        stockId = 2;
                        newQuantity = int.TryParse(Quantity2.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                    case "StockItem3":
                        stockId = 3;
                        newQuantity = int.TryParse(Quantity3.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                    case "StockItem4":
                        stockId = 4;
                        newQuantity = int.TryParse(Quantity4.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                    case "StockItem5":
                        stockId = 5;
                        newQuantity = int.TryParse(Quantity5.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                    case "StockItem6":
                        stockId = 6;
                        newQuantity = int.TryParse(Quantity6.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                    case "StockItem7":
                        stockId = 7;
                        newQuantity = int.TryParse(Quantity7.Text.Trim(), out newQuantity) ? newQuantity : 0;
                        break;
                }

                // If the new stock name is valid (not empty) and the stockId is valid, update both name and quantity
                if (!string.IsNullOrEmpty(newStockName) && stockId != 0)
                {
                    UpdateStockItem(stockId, newStockName, newQuantity);
                }
                else
                {
                    MessageBox.Show("Invalid stock name or quantity.");
                }
            }
        }

        // This method is triggered when the form loads
        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            ManageStockItems();

            // Hook up the text changed events
            Quantity1.TextChanged += QuantityTextBox_TextChanged;
            Quantity2.TextChanged += QuantityTextBox_TextChanged;
            Quantity3.TextChanged += QuantityTextBox_TextChanged;
            Quantity4.TextChanged += QuantityTextBox_TextChanged;
            Quantity5.TextChanged += QuantityTextBox_TextChanged;
            Quantity6.TextChanged += QuantityTextBox_TextChanged;
            Quantity7.TextChanged += QuantityTextBox_TextChanged;

            StockItem1.TextChanged += StockItemTextBox_TextChanged;
            StockItem2.TextChanged += StockItemTextBox_TextChanged;
            StockItem3.TextChanged += StockItemTextBox_TextChanged;
            StockItem4.TextChanged += StockItemTextBox_TextChanged;
            StockItem5.TextChanged += StockItemTextBox_TextChanged;
            StockItem6.TextChanged += StockItemTextBox_TextChanged;
            StockItem7.TextChanged += StockItemTextBox_TextChanged;
        }

        // User management button event
        private void usermanagement_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("User management section entered.");
        }

        // Logout button event
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();  // Close the application
            }
        }
    }
}
