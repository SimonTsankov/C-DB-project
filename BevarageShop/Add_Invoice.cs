using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace BevarageShop
{
    public partial class Add_Invoice : Form
    {
        Database database = new Database();
        public Add_Invoice()
        {
            InitializeComponent();
            CB_clients.DataSource = getClientsSQL(database);
            CB_clients.ValueMember = "ID";
            CB_clients.DisplayMember = "name";

        }

        public List<ClientClass> getClientsSQL(Database database)
        {
            List<ClientClass> list = new List<ClientClass>();

            database.OpenConnection();
            string query = "SELECT id_client, name FROM Client;";
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            SQLiteDataReader result = myCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    list.Add(new ClientClass(string.Format(result["name"] + "   id: {0}", result["id_client"]), Convert.ToInt32(result["id_client"])));
                }
            }
            database.CloseConnection();
            return list;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {

            Database database = new Database();
            string query = "INSERT INTO Invoice VALUES(@id_invoice, @id_client, @CreationDate, @TotalCost)";
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
            database.OpenConnection();
            var result = 0;
            try
            {
                myCommand.Parameters.AddWithValue("@id_invoice", Int32.Parse(id_invoice.Text));
                myCommand.Parameters.AddWithValue("@id_client", CB_clients.SelectedValue);
                myCommand.Parameters.AddWithValue("@CreationDate", Date_field.Text);
                myCommand.Parameters.AddWithValue("@TotalCost", "0");
                result = myCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
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
        

        public int getTotalCost(string id_invoice)
        {
            int total = 0;
            try { 
            Database database = new Database();
            database.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id_ivItem FROM InvoiceItem WHERE id_invoice ==" + id_invoice, database.myConnection);
            SQLiteDataReader result_id_invoice = cmd.ExecuteReader();
            if (result_id_invoice.HasRows)
            {
                while (result_id_invoice.Read())
                {
                    string query = "SELECT price*(SELECT quantity FROM InvoiceItem WHERE id_ivItem== "+result_id_invoice["id_ivItem"]+ ") AS price2 " +
                        "FROM Drink WHERE id_drink IN(SELECT id_drink FROM InvoiceItem WHERE id_ivItem== "+result_id_invoice["id_ivItem"]+")";
                    cmd = new SQLiteCommand(query, database.myConnection);
                   
                    SQLiteDataReader result_pricesXquantity = cmd.ExecuteReader();
                    result_pricesXquantity.Read();
                   
                    total += Convert.ToInt32(result_pricesXquantity["price2"]);
                    
                }
            }
            database.CloseConnection();
            }catch(Exception ee)
            {

            }
            return total;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cost_field.Text = getTotalCost(id_invoice.Text)+"";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cost_field.Text = getTotalCost(id_invoice.Text) + "";
        }
    }
    public class ClientClass
    {
        public String name { get; set; }
        public int ID { get; set; }

        public ClientClass(string n, int i)
        {
            name = n;
            ID = i;
        }

    }
}
