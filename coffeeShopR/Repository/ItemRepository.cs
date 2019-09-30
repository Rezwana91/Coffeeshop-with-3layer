using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace coffeeShopR.Repository
{
    public class ItemRepository
    {
        public bool Add(string name, double price)
        {
            bool isadded = false;
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"insert into items (itemname,price) values ('" + name + "','" + price + "');";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            int isExucuted = sqlCommand.ExecuteNonQuery();

            if (isExucuted > 0)
            {
                isadded = true;
            }


            //Close

            sqlConnection.Close();

            return isadded;

        }

        public bool IsNameExist(string name)
        {

            bool exist = false;

            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from items where itemname ='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;


            if (dataTable.Rows.Count > 0)
            {
                exist = true;
            }


            //Close

            sqlConnection.Close();

            return exist;
        }

        public bool Delete(int id)
        {
            bool isdeleted = false;
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"delete from items where id='" + id + "';";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            int isExucuted = sqlCommand.ExecuteNonQuery();

            if (isExucuted > 0)
            {
                isdeleted = true;
            }


            //Close

            sqlConnection.Close();

            return isdeleted;


        }

        public bool Update(string name, double price, int id)

        {
            bool isupdate = false;


            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"update items set itemname='" + name + "',price='" + price + "' where id='" + id + "';";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            int isexecute = sqlCommand.ExecuteNonQuery();

            if (isexecute > 0)
            {
                isupdate = true;
            }

            //Close

            sqlConnection.Close();

            return isupdate;
        }

        public DataTable Display()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from items";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;


            //if (dataTable.Rows.Count > 0)
            //{
            //    showdataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("Data Tabel not found");

            //}

            //Close

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable Search(string name)
        {

            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from items where itemname ='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           // showdataGridView.DataSource = dataTable;


            //if (dataTable.Rows.Count > 0)
            //{
            //    showdataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("Data Tabel not found");

            //}

            //Close

            sqlConnection.Close();
            return dataTable;

        }


    }
}
