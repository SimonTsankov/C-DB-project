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
    public partial class Add_InvoiceItem1 : Form
    {
        public Add_InvoiceItem1()
        {
            InitializeComponent();
            CB_Drink.DataSource = getDrinks();
            CB_Drink.ValueMember = "ID";
            CB_Drink.DisplayMember = "name";
            CB_id.DataSource = getIDs();
            CB_id.ValueMember = "ID";
            CB_id.DisplayMember = "name";
        }
        public List<IdClass> getIDs()
        {
            List<IdClass> list = new List<IdClass>();

            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT id_invoice from Invoice", c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                list.Add(
                                    new IdClass("ID: " + result["id_invoice"], Convert.ToInt32(result["id_invoice"]))
                                    );
                            }
                           
                        }
                    }
                }
                return list;
            }
            return list;
        }
        public List<DrinkClass> getDrinks()
        {
            Database database = new Database();
            List<DrinkClass> list = new List<DrinkClass>();
            database.OpenConnection();
            string query = "SELECT id_drink, name FROM Drink";
            SQLiteCommand cmd = new SQLiteCommand(query, database.myConnection);
            SQLiteDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    list.Add(
                        new DrinkClass(
                            string.Format(result["name"] + "    id: {0}", result["id_drink"])
                            , Convert.ToInt32(result["id_drink"])
                        )
                        );

                }
            }
            database.CloseConnection();
            return list;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.OpenConnection();
            string query = "INSERT INTO InvoiceItem VALUES(@id_ivItem,@id_invoice,@quantity,@id_drink)";
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            var result = 0;
            try { 
            myCommand.Parameters.AddWithValue("@id_ivItem", (id_II_field.Text));
            myCommand.Parameters.AddWithValue("@id_invoice", CB_id.SelectedValue);
            myCommand.Parameters.AddWithValue("@quantity", (textBox2.Text));
            myCommand.Parameters.AddWithValue("@id_drink", (CB_Drink.SelectedValue));
                myCommand.ExecuteNonQuery();
            }catch(Exception ee)
            {
                
            }
        }
        public class IdClass
        {
            public string name { get; set; }
            public int ID { get; set; }

            public IdClass(string n, int i)
            {
                name = n;
                ID = i;
            }
        }
        public class DrinkClass{
           public string name { get; set; }
           public  int ID { get; set; }

            public DrinkClass(string n, int i)
            {
                name = n;
                ID = i;
            }
        }
    }
}
