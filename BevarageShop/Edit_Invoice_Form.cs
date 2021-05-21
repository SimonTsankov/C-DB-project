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
    public partial class Edit_Invoice_Form : Form
    {
        public Edit_Invoice_Form()
        {
            InitializeComponent();
            Database database = new Database();
            Add_Invoice obj = new Add_Invoice();
            CB_clients.DataSource = obj.getClientsSQL(database);
            CB_clients.ValueMember = "ID";
            CB_clients.DisplayMember = "name";
            UpdateTextField();
        }
        int id = Form1.SelectedID;
        public void UpdateTextField()
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from Invoice WHERE id_invoice = " + id, c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            result.Read();
                            date_field.Text = result["CreationDate"] + "";         
                            Id_label.Text += id;
                            
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
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Invoice SET CreationDate = @creationdate, id_client = @id_client WHERE id_invoice = " + id, c))
                {
                    cmd.Parameters.AddWithValue("@creationdate", date_field.Text);
                    cmd.Parameters.AddWithValue("@id_client", CB_clients.SelectedValue);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
