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
    public partial class Add_Client_form : Form
    {
        public Add_Client_form()
        {
            InitializeComponent();
        }


        private void Client_add_btn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            string query = "INSERT INTO Client VALUES(@id_client,@EGN,@name,@adress,@number)";
            SQLiteCommand myCommand = new SQLiteCommand(query,database.myConnection);
            database.OpenConnection();
            var result=0;
            try {
                myCommand.Parameters.AddWithValue("@id_client", Int32.Parse(id_client_field.Text));
                myCommand.Parameters.AddWithValue("@EGN",EGN_field.Text);
                myCommand.Parameters.AddWithValue("@name",Name_field.Text);
                myCommand.Parameters.AddWithValue("@adress",Adress_field.Text);
                myCommand.Parameters.AddWithValue("@number", Number_field.Text);
                result= myCommand.ExecuteNonQuery();
            }catch(Exception ee)
            {
                Status_label.Text = "Error! Try again";
                Status_label.BackColor = Color.Red;
                
            
            }
            if(result == 0)
            {
                Status_label.Text = "Error! Try again";
                Status_label.BackColor = Color.Red;
            }
            else { 
            Status_label.Text = "Client added!";
            Status_label.BackColor = Color.Green;
            }
            database.CloseConnection();
        }
    }
}
