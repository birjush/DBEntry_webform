using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBEntry
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubBtn_Click(object sender, EventArgs e)
        {
            String n1 = Textbox1.Text;
            String n2 = Textbox2.Text;
            Console.WriteLine("name is : " + n1);
            Console.WriteLine("surname is : " + n2);
            //lbl_output.Text = n1 + " " + n2;
            SqlConnection sqlConnection;
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BIRJU\source\repos\DBEntry\DBEntry\App_Data\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            string insertQuery = $"INSERT INTO student(name,surname) VALUES ('{n1}','{n2}')";
            SqlCommand insertcommand = new SqlCommand(insertQuery,sqlConnection) ;
            insertcommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}