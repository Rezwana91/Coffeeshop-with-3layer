using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeShopR.Manager;

namespace coffeeShopR
{
    public partial class customer : Form
    {

        CustomerManager _customerManager = new CustomerManager();

        public customer()
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
            if (_customerManager.IsNameExist(customernameTextBox.Text))
            {
                MessageBox.Show(customernameTextBox.Text + " Already Exists!");
                return;
            }

            bool isAdded = _customerManager.Add(customernameTextBox.Text,addressTextBox.Text,contactTextBox.Text);


          if (isAdded)
          {
              MessageBox.Show("Saved");
              showdataGridView.DataSource = _customerManager.Display();

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

            
            bool isDeleted = _customerManager.Delete(Convert.ToInt16(idTextBox.Text));

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
                showdataGridView.DataSource = _customerManager.Display();
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

            bool isUpdated = _customerManager.Update(customernameTextBox.Text, addressTextBox.Text, contactTextBox.Text, Convert.ToInt16(idTextBox.Text));

            if (isUpdated)
            {
                MessageBox.Show("Updated");
                showdataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

           

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showdataGridView.DataSource = _customerManager.Display();


        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            ////Set Name as Mandatory

            if (String.IsNullOrEmpty(customernameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }          
           
            showdataGridView.DataSource = _customerManager.Search(customernameTextBox.Text);
        }
        
    }
}
