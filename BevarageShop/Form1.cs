using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace BevarageShop
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("Select * from Client", c))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            fillDictionaries();
        }
       
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            
            string table = returnTableName();

            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("Select * from " + table, c))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        
                    }
                }
            }
            dataGridView1.Columns[Table_IDs[table]].DisplayIndex = 0;
            updateTotalCost();
        }
        #region CostUpdateing

        public void updateTotalCost()
        {
            LinkedList<string> resultsList = new LinkedList<string>();
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT id_invoice FROM Invoice", c))
                {
                    using (SQLiteDataReader result = cmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                resultsList.AddLast(result["id_invoice"] + "");
                            }
                        }
                    }
                }
            }
            LinkedList<int> totalList = new LinkedList<int>();
            foreach(string item in resultsList)
            {
                totalList.AddLast(getTotalCost(item));
            }
           
            for (int i =0;i<resultsList.Count;i++)
            {
                setTotalCost(resultsList.ElementAt(i), totalList.ElementAt(i));
               
            }
        }
        public int getTotalCost(string id_invoice)
        {
            int total = 0;
            LinkedList<string> queries = new LinkedList<string>();
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT id_ivItem FROM InvoiceItem WHERE id_invoice ==" + id_invoice, c))
                {
                    using (SQLiteDataReader result_id_invoice = cmd.ExecuteReader())
                    {
                        if (result_id_invoice.HasRows)
                        {
                            while (result_id_invoice.Read())
                            {
                                string query = "SELECT price*(SELECT quantity FROM InvoiceItem WHERE id_ivItem== " + result_id_invoice["id_ivItem"] + ") AS price2 " +
                                    "FROM Drink WHERE id_drink IN(SELECT id_drink FROM InvoiceItem WHERE id_ivItem== " + result_id_invoice["id_ivItem"] + ")";
                                queries.AddLast(query);
                            }

                        }
                    }
                }
            }

            foreach (string query in queries)
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader result_pricesXquantity = cmd.ExecuteReader())
                        {
                            result_pricesXquantity.Read();

                            total += Convert.ToInt32(result_pricesXquantity["price2"]);
                        }
                    }
                }
            }
            return total;
        }
        public void setTotalCost(string id, int cost)
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Invoice SET TotalCost = " + cost + " WHERE id_invoice = " + id, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
        private string returnTableName()
        {
            string table = "Client";
            switch (comboBox1.GetItemText(this.comboBox1.SelectedItem))
            {
                case "Client":
                    table = "Client";
                    break;
                case "Invoices":
                    table = "Invoice";
                    break;
                case "Drinks":
                    table = "Drink";
                    break;
                case "Invoice Items":
                    table = "InvoiceItem";
                    break;
                case "Distributors":
                    table = "Distributor";
                    break;
            }
            return table;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.GetItemText(this.comboBox1.SelectedItem))
            {
                case "Clients":
                    Add_Client_form form2 = new Add_Client_form();
                    form2.Show();

                    break;
                case "Invoices":
                    Add_Invoice invoice_form = new Add_Invoice();
                    invoice_form.Show();

                    break;
                case "Drinks":
                    Add_Drink drinks_form = new Add_Drink();
                    drinks_form.Show();

                    break;
                case "Invoice Items":
                    Add_InvoiceItem1 form = new Add_InvoiceItem1();
                    form.Show();

                    break;
                case "Distributors":
                    Add_Distributor distributor_form = new Add_Distributor();
                    distributor_form.Show();

                    break;
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try { 
            int rowsSelected = dataGridView1.SelectedRows.Count;
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete number of rows: " + dataGridView1.SelectedRows.Count, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)      
                for (int i = 0; i < rowsSelected ; i++)
                {             
                    int selectedrowindex = dataGridView1.SelectedCells[i].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    int cellValue = Convert.ToInt32(selectedRow.Cells[Table_IDs[returnTableName()]].Value);
                        try {
                            MessageBox.Show(cellValue+"");
                        DeleteRowSQL(cellValue);
                        }
                        catch ( Exception eee)
                        {

                        }



                }
            }catch(Exception ee)
            {

            }

        }
        private void DeleteRowSQL(int id)
        {
            string table = returnTableName();
            database.OpenConnection();
            string id_name = Table_IDs[table];
            string query = "DELETE FROM " + table + " WHERE " + id_name + " = " + id;
            Debuging_label.Text = query;
            SQLiteCommand cmd = new SQLiteCommand(query, database.myConnection);
            cmd.ExecuteNonQuery();
            database.CloseConnection();
            refresh_btn.PerformClick();
        }

        Dictionary<string, string> Table_IDs = new Dictionary<string, string>();
        private void fillDictionaries()
        {
            Table_IDs.Add("Client", "id_client");
            Table_IDs.Add("Distributor", "id_distributor");
            Table_IDs.Add("Drink", "id_drink");
            Table_IDs.Add("Invoice", "id_invoice");
            Table_IDs.Add("InvoiceItem", "id_ivItem");
        }

       

        public int getSelectedID()
        {
            int id = 0;
            int rowsSelected = dataGridView1.SelectedRows.Count;
                for (int i = 0; i < rowsSelected ; i++)
                {             
                    int selectedrowindex = dataGridView1.SelectedCells[i].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    id = Convert.ToInt32(selectedRow.Cells[Table_IDs[returnTableName()]].Value);         
                }
            return id;
        }
        public static int SelectedID = 0; 
        private void edit_btn_Click(object sender, EventArgs e)
        {
            SelectedID = getSelectedID();
            switch (comboBox1.GetItemText(this.comboBox1.SelectedItem))
            {
                case "Clients":
                    Edit_Client_Form form = new Edit_Client_Form();
                    form.Show();
                    break;
                case "Invoices":
                    Edit_Invoice_Form form1 = new Edit_Invoice_Form();
                    form1.Show();
                    break;
                case "Drinks":
                    Edit_Drink drinkForm = new Edit_Drink();
                    drinkForm.Show();

                    break;
                case "Invoice Items":
                    Edit_Invoice_Item form2 = new Edit_Invoice_Item();
                    form2.Show();

                    break;
                case "Distributors":
                    Edit_Distributor disForm = new Edit_Distributor();
                    disForm.Show();

                    break;
            }
        }
        public  void ExecuteNonQuerySQL(String query)
        {
            var rowsAffected=0;
            try
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                       
                       rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                queryStatus.ForeColor = Color.Black;
                queryStatus.Text =rowsAffected + " rows affected";
            }
            catch(Exception ee)
            {
                queryStatus.ForeColor = Color.Red;
                queryStatus.Text = ee.Message;
            }
        }
        public void ExecuteReturnQuery(String query)
        {
            try { 
            using (SQLiteConnection c = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                    queryStatus.ForeColor = Color.Black;
                    queryStatus.Text = "";
            }
            }catch(Exception ee)
            {
                queryStatus.ForeColor = Color.Red;
                queryStatus.Text = ee.Message;
            }
        }
        private void executeSQL_btn_Click(object sender, EventArgs e)
        {
            if (sql_text_field.Text.ToLower().Contains("select") == true)
            {
                ExecuteReturnQuery(sql_text_field.Text);
            }
            else ExecuteNonQuerySQL(sql_text_field.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_btn.PerformClick();
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                openFileDialog.Filter = "SQL files|*.sql";
                openFileDialog.RestoreDirectory = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    queryStatus.Text = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();//sql script
                        if (fileContent.ToLower().Contains("select") == true)//execution of sql script
                        {
                            ExecuteReturnQuery(fileContent);
                        }
                        else ExecuteNonQuerySQL(fileContent);
                    }
                }
            }
        }
    }
}
