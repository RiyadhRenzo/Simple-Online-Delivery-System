using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace itep_database_finals
{
    public partial class Form2 : Form
    {
        string mysqlCon = "server=127.0.0.1; port=3307; user=root; database=itep finals;";
        MySqlConnection mySqlConnection;

        public Form2()
        {
            InitializeComponent();

            mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
        }

        private void SomeMethod()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM PRODUCTS", mySqlConnection);
        }

        private void pictureBox1_Click(object sender, EventArgs e)//GREEN TEA
        {
            AddToCart("Organic Green Tea Facial Tissue");
        }

        private void pictureBox3_Click(object sender, EventArgs e)//FAN
        {
            AddToCart("GGCO Solar Electric Fan");
        }

        private void pictureBox4_Click(object sender, EventArgs e)//STOVE
        {
            AddToCart("Portable Multifunctional Gas Stove");
        }

        private void pictureBox5_Click(object sender, EventArgs e)//MATTRESS
        {
            AddToCart("Foldable Mattress Foam (Thin)");
        }

        private void pictureBox6_Click(object sender, EventArgs e)//DRESS
        {
            AddToCart("Honey Top Fashion Bundle Clothes");
        }

        private void pictureBox7_Click(object sender, EventArgs e)//POT
        {
            AddToCart("Non-stick Soup Pot Induction Stew");
        }

        private void AddToCart(string itemName)
        {
            DialogResult result = MessageBox.Show("Add to Cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO Cart (ItemName) VALUES (@ItemName)", mySqlConnection);
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(itemName + " has been placed in your cart!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add " + itemName + " to cart.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding item to cart: " + ex.Message);
                }
                finally
                {
                    DialogResult endshop = MessageBox.Show("Continue Shopping?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (endshop == DialogResult.No) {
                        mySqlConnection.Close();}
                    else
                    {
                        MessageBox.Show("Enjoy your Shopping!");
                    }
                }
            }
            else
            {
                MessageBox.Show("You said no thanks.");
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Go back to Form1
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}