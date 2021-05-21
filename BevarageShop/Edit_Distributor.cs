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
    public partial class Edit_Distributor : Form
    {
        public Edit_Distributor()
        {
            InitializeComponent();
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from Distributor WHERE id_distributor = " + Form1.SelectedID, c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            result.Read();
                            name_field.Text = result["name"] + "";
                            number_field.Text = result["phone_number"] + "";
                            ID_label.Text += Form1.SelectedID;

                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Distributor SET name = @name , phone_number = @number WHERE id_distributor = " + Form1.SelectedID, c))
                {
                    cmd.Parameters.AddWithValue("@name", name_field.Text);
                    cmd.Parameters.AddWithValue("@number", number_field.Text);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
