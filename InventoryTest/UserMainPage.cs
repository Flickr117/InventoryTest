using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class UserMainPage : Form
    {
        string itemName;
        string currentItem;
        int itemQuantity;
        double price;
        double totalPrice;

        public UserMainPage()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Enter_Keydown);
        }

        private void itemInput_TextChanged(object sender, EventArgs e)
        {
            itemName = itemInput.Text;
            currentItem = itemName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Quantity Input
        {
            if (int.TryParse(quantityInput.Text, out int result))
            {
                itemQuantity = result; // Assign the parsed integer to itemQuantity
                quantityError.Text = "";
            }
            else
            {
                itemQuantity = 0; // Default value or handle invalid input here
                quantityError.Text = "Please only input whole numbers!";
            }
        }
        private void Enter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemNameField.Text = currentItem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("The Program will now close.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void itemNameField_Click(object sender, EventArgs e)
        {
            itemNameField.Text = currentItem;
        }
    }
}
