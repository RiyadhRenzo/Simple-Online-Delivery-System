using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itep_database_finals
{
    public partial class Form3 : Form
    {
        string mysqlCon = "server=127.0.0.1; port=3307; user=root; database=itep finals;";
        MySqlConnection mySqlConnection;
        public Form3()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
            DisplayCartItems();
        }
        public void DisplayCartItems()
        {


            MySqlDataAdapter adapter = new MySqlDataAdapter(@"
        SELECT c.CartID, c.ItemName AS CartItemName, p.ProductID, p.ProductName AS ProductName, c.CheckoutStatus
        FROM Cart c
        INNER JOIN Products p ON c.ItemName LIKE CONCAT('%', p.ProductName, '%')", mySqlConnection);


            DataTable cartItemsTable = new DataTable();
            adapter.Fill(cartItemsTable);

            
            try
            {

                if (cartItemsTable.Rows.Count != 0)
                {
                    dataGridView1.DataSource = cartItemsTable;
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Nothing. Cart Is Empty.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        private void checkout_Click(object sender, EventArgs e)//CHECKOUT
        {
            DialogResult checkout = MessageBox.Show("Are you sure? You cannot cancel once you checked out.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (checkout == DialogResult.Yes) {
                using (MySqlCommand command = mySqlConnection.CreateCommand())
                {
                    // Set the checkout status to 'CheckedOut' for all items in the cart
                    command.CommandText = "UPDATE Cart SET CheckoutStatus = 'CheckedOut'";
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        CopyCheckedOutItemsToReceiptTable();
                        MessageBox.Show("Checkout successful. Your order has been placed, and you will receive the receipt upon arrival of product.");
                        DisplayCartItems();
                    }
                    else
                    {
                        MessageBox.Show("No items were found in the cart to be checked out.");
                    }
                }
            }
            else
            {
                MessageBox.Show("You didn't checkout.");

            }
        }
        private void CopyCheckedOutItemsToReceiptTable()
        {
            try
            {
                using (MySqlCommand command = mySqlConnection.CreateCommand())
                {
                    // Insert checked out items into Receipt table from Cart table
                    command.CommandText = "INSERT INTO Receipt (ProductName, Price, Discount, PriceAfterDiscount) " +
                                            "SELECT Products.ProductName, Products.Price, Products.Discount, Products.PriceAfterDiscount " +
                                            "FROM Cart INNER JOIN Products ON Cart.ItemName = Products.ProductName " +
                                            "WHERE Cart.CheckoutStatus = 'CheckedOut'";

                    int rowsInserted = command.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        // Successfully copied items to receipt table
                    }
                    else
                    {
                        // No items checked out or inserted into receipt table
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying checked out items to receipt table: " + ex.Message);
            }
        }
        private void checkout_Load(object sender, EventArgs e)//empty
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }//empty

        //----------------------------------------------------------------------
        private void backtoform2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();

        }//GO BACK TO SHOPPING

        private void backtoform1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }//HOME

        private void remove_Click(object sender, EventArgs e)
        {
            int cartIDToDelete;
            if (!int.TryParse(txtCartIDToDelete.Text, out cartIDToDelete))
            {
                MessageBox.Show("Please enter a valid CartID.");
                return;
            }
            {
                using (MySqlCommand command = mySqlConnection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Cart WHERE CartID = @CartID";
                    command.Parameters.AddWithValue("@CartID", cartIDToDelete);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item Removed.");
                        DisplayCartItems();
                        txtCartIDToDelete.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No Items Found.");
                    }
                }
            }
        }//REMOVING THE ITEMS

        private void cancel_Click(object sender, EventArgs e)//CANCEL THE ORDER STATUS
        {
            int cartIDToCancel;
            if (!int.TryParse(txtCartIDToCancel.Text, out cartIDToCancel))
            {
                MessageBox.Show("Please enter a valid CartID.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MySqlCommand command = mySqlConnection.CreateCommand())
                {
                    command.CommandText = "UPDATE Cart SET CheckoutStatus = 'Canceled' WHERE CartID = @CartID";
                    command.Parameters.AddWithValue("@CartID", cartIDToCancel);

                    MessageBox.Show("Order Canceled.");
                    DisplayCartItems();
                    txtCartIDToCancel.Clear();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        result = MessageBox.Show("Do you want to delete this item from the cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            command.CommandText = "DELETE FROM Cart WHERE CartID = @CartID";
                            rowsAffected = command.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected > 0 ? "Item deleted from the cart." : "Failed to delete item from the cart.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("You didn't delete.");
                    }
                }

        }
    }
}}
