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
using System.Configuration;

namespace AppDB
{
    public partial class ClientDB : Form
    {
        private SqlConnection sqlconnection;
        public ClientDB()
        {
            InitializeComponent();
        }

        private void ClientDB_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["OrdersDB"].ConnectionString);
            sqlconnection.Open();
        }

        private void Insert_new_Click(object sender, EventArgs e)
        {
            int check;
            SqlCommand NewOrder = new SqlCommand(
                $"INSERT INTO Orders VALUES(@Num, @Date, @Contract_ID, @Provider, @Storage)", sqlconnection);

            string date = Date.Value.Date.ToString("dd-MM-yy");

            NewOrder.Parameters.AddWithValue("Num", num.Value);
            NewOrder.Parameters.AddWithValue("Date", date);
            NewOrder.Parameters.AddWithValue("Contract_ID", Convert.ToInt32(ContractID.Text));
            NewOrder.Parameters.AddWithValue("Provider", Provider.Text);
            NewOrder.Parameters.AddWithValue("Storage", Storage.Text);

            SqlCommand NewSupply = new SqlCommand(
                $"INSERT INTO Supply VALUES(@Contract_ID, @Products_ID, @numOfProd, " +
                $"(SELECT Price FROM Products WHERE Product_ID = @Products_ID)*@numOfProd)", sqlconnection);

            NewSupply.Parameters.AddWithValue("Contract_ID", Convert.ToInt32(ContractID.Text));
            NewSupply.Parameters.AddWithValue("Products_ID", Convert.ToInt32(ProductsID.Text));
            NewSupply.Parameters.AddWithValue("numOfProd", numOfProducts.Value);

            check = NewOrder.ExecuteNonQuery();
            check += NewSupply.ExecuteNonQuery();
            if(check == 2)
            {
                MessageBox.Show("Успешно!");
            }
            else if(check < 2)
            {
                MessageBox.Show("Произошла ошибка!");
                SqlCommand delSepply = new SqlCommand($"DELETE FROM Supply WHERE Contract_ID = {Convert.ToInt32(ContractID.Text)}", sqlconnection);
                SqlCommand delOrders = new SqlCommand($"DELETE FROM Orders WHERE Contract_ID = {Convert.ToInt32(ContractID.Text)}", sqlconnection);
            }
        }

    }
}
