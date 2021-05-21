using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace BevarageShop
{
    public partial class Add_Drink : Form
    {
        public Add_Drink()
        {
            InitializeComponent();
            CB_DistributorId.DataSource = getDistributors(new Database());
            CB_DistributorId.ValueMember = "ID";
            CB_DistributorId.DisplayMember = "name";
        }
        public List<DistributorsClass> getDistributors(Database database)
        {
            List<DistributorsClass> list = new List<DistributorsClass>();

            database.OpenConnection();
            string query = "SELECT id_distributor, name FROM Distributor";
            SQLiteCommand cmd = new SQLiteCommand(query, database.myConnection);
            SQLiteDataReader result = cmd.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    list.Add(
                        new DistributorsClass(
                            string.Format(result["name"] + "    id: {0}", result["id_distributor"])
                            , Convert.ToInt32(result["id_distributor"])
                        )
                        );

                }
            }
            database.CloseConnection();
            return list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.OpenConnection();
            string query = "INSERT INTO Drink VALUES(@id_drink,@name,@bought,@price,@id_distributor,@date_added)";
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            var result = 0;           
                myCommand.Parameters.AddWithValue("@id_drink", id_drink_field.Text);
                myCommand.Parameters.AddWithValue("@name", (name_field.Text));
                myCommand.Parameters.AddWithValue("@bought", Convert.ToInt32(bought_field.Text));
                myCommand.Parameters.AddWithValue("@price", Convert.ToInt32(price_field.Text));
                myCommand.Parameters.AddWithValue("@id_distributor", CB_DistributorId.SelectedValue);
                myCommand.Parameters.AddWithValue("@date_added", date_field.Text);
                result = myCommand.ExecuteNonQuery();       
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
        public class DistributorsClass
        {
            public String name { get; set; }
            public int ID { get; set; }

            public DistributorsClass(string n, int i)
            {
                name = n;
                ID = i;
            }
        }
    }
}
