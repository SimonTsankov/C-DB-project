using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BevarageShop
{
    public partial class Edit_Drink : Form
    {
        public Edit_Drink()
        {
            InitializeComponent();
            Add_Drink obj = new Add_Drink();
            CB_distributors.DataSource = obj.getDistributors(new Database());
            CB_distributors.ValueMember = "ID";
            CB_distributors.DisplayMember = "name";
            UpdateFields();
        }
        public void UpdateFields()
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from Drink WHERE id_drink = " + Form1.SelectedID, c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            result.Read();
                            name_field.Text = result["name"] + "";
                            bought_field.Text = result["bought"] + "";
                            price_field.Text = result["price"] + "";
                            date_field.Text = result["date_added"] + "";

                        }
                    }
                }
            }
        }
  

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Drink SET name = @name, bought = @bought, price = @price, id_distributor = @id_distributor, date_added = @date_added WHERE id_drink = " + Form1.SelectedID, c))
                    {
                        cmd.Parameters.AddWithValue("@name", name_field.Text);
                        cmd.Parameters.AddWithValue("@bought", bought_field.Text);
                        cmd.Parameters.AddWithValue("@price", price_field.Text);
                        cmd.Parameters.AddWithValue("@id_distributor", CB_distributors.SelectedValue);
                        cmd.Parameters.AddWithValue("@date_added", date_field.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error! Inputs are not correct! ", "Somethimg went wrong");
            }
        }
    }
}
