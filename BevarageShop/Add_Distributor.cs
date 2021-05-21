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
    public partial class Add_Distributor : Form
    {
        public Add_Distributor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            string query = "INSERT INTO Distributor VALUES(@id_distributor, @name, @phone_number)";
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            database.OpenConnection();
            var result = 0;
            try
            {
                myCommand.Parameters.AddWithValue("@id_distributor", Int32.Parse(id_field.Text));
                myCommand.Parameters.AddWithValue("@name", name_field.Text);
                myCommand.Parameters.AddWithValue("@phone_number", phone_filed.Text);
                result = myCommand.ExecuteNonQuery();
            }
            catch(Exception ee)
            {
                Status_label.Text = "Error! Try again";
                Status_label.BackColor = Color.Red;
            }
            if (result == 0)
            {
                Status_label.Text = "Error! Try again";
                Status_label.BackColor = Color.Red;
            }
            else
            {
                Status_label.Text = "Client added!";
                Status_label.BackColor = Color.Green;
            }
            database.CloseConnection();
        }
    }
}
