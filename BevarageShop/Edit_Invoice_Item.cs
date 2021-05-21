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
    public partial class Edit_Invoice_Item : Form
    {
        public Edit_Invoice_Item()
        {
            InitializeComponent();
            Add_InvoiceItem1 obj = new Add_InvoiceItem1();
            CB_Drink.DataSource = obj.getDrinks();
            CB_Drink.ValueMember = "ID";
            CB_Drink.DisplayMember = "name";
            CB_id_invoice.DataSource = obj.getIDs();
            CB_id_invoice.ValueMember = "ID";
            CB_id_invoice.DisplayMember = "name";
            UpdateFields();
        }
        int id = Form1.SelectedID;
        public void UpdateFields()
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from InvoiceItem WHERE id_ivItem = " + id, c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            result.Read();
                            quantity_field.Text = result["quantity"] + "";
                            label4.Text += " "+id;
                            

                        }
                    }
                }
            }
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE InvoiceItem SET quantity = @quantity, id_drink = @id_drink, id_invoice = @id_invoice WHERE id_ivItem = " + id, c))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity_field.Text);
                    cmd.Parameters.AddWithValue("@id_drink", CB_Drink.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_invoice", CB_id_invoice.SelectedValue);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
