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
    public partial class Edit_Client_Form : Form
    {
        public Edit_Client_Form()
        {
            InitializeComponent();
            UpdateTextFields();

        }
        int id = Form1.SelectedID;
        public void UpdateTextFields()
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from Client WHERE id_client = " + id, c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            result.Read();
                            name_field.Text = result["name"] + "";
                            egn_field.Text = result["EGN"] + "";
                            adress_field.Text = result["adress"] + "";
                            number_field.Text = result["number"] + "";
                            Client_ID_label.Text += " " + result["id_client"];
                     
                        }
                    }
                }
            }
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Client SET EGN = @egn,  name = @name,  adress = @adress,  number = @number WHERE id_client = " + id, c))
                {
                    cmd.Parameters.AddWithValue("@egn", egn_field.Text);
                    cmd.Parameters.AddWithValue("@name", name_field.Text);
                    cmd.Parameters.AddWithValue("@adress", adress_field.Text);
                    cmd.Parameters.AddWithValue("@number", number_field.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            

        }
    }
}
