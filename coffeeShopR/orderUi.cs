using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeShopR.Manager;

namespace coffeeShopR
{
    public partial class orderUi : Form
    {
        private OrderManager _orderManager = new OrderManager();

        public orderUi()
        {
            InitializeComponent();
        }

         private void addButton_Click(object sender, EventArgs e)
        {

            //Set Name as Mandatory
            if (String.IsNullOrEmpty(customernameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            //Check UNIQUE
            if (_orderManager.IsNameExist(customernameTextBox.Text))
            {
                MessageBox.Show(customernameTextBox.Text + " Already Exists!");
                return;
            }

            //Check UNIQUE
            //if (_orderManager.IsInameExist(itemnameTextBox.Text))
            //{
            //    MessageBox.Show(itemnameTextBox.Text + " Already Exists!");
            //    return;
            //}

            bool isAdded = _orderManager.Add(Convert.ToInt16(quantityTextBox.Text), Convert.ToDouble(totalpriceTextBox.Text), customernameTextBox.Text,itemnameTextBox.Text);


            if (isAdded)
            {
                MessageBox.Show("Saved");
                showdataGridView.DataSource= _orderManager.Display();

            }
            else
            {
                MessageBox.Show("Not Saved");
            }



        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ////Set ID as Mandatory

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("ID Can not be Empty!!!");
                return;
            }


            bool isDeleted = _orderManager.Delete(Convert.ToInt16(idTextBox.Text));

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
                showdataGridView.DataSource = _orderManager.Display();
            }
            else
            {
                MessageBox.Show(" Not Deleted");

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ////Set ID as Mandatory

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("ID Can not be Empty!!!");
                return;
            }

            bool isUpdated = _orderManager.Update(Convert.ToInt16(quantityTextBox.Text), Convert.ToDouble(totalpriceTextBox.Text), customernameTextBox.Text,itemnameTextBox.Text, Convert.ToInt16(idTextBox.Text));

            if (isUpdated)
            {
                MessageBox.Show("Updated");

                showdataGridView.DataSource = _orderManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {

            showdataGridView.DataSource = _orderManager.Display();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            ////Set Name as Mandatory

            //if (String.IsNullOrEmpty(customernameTextBox.Text))
            //{
            //    MessageBox.Show("Name Can not be Empty!!!");
            //    return;
            //}
            

            showdataGridView.DataSource = _orderManager.Search(customernameTextBox.Text, itemnameTextBox.Text);
        }

       



        //Method
        //Add


        //delete


        //update


        //show






    }
}
