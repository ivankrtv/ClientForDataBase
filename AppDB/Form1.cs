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

        private void Insert_new_Click(object sender, EventArgs e)   // обработка добавления заказа в таблицы
        {                                                           // Orders и Supply
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

        private void Search_Click(object sender, EventArgs e)   // обработка поиска заказа по номеру договора
        {
            SqlDataAdapter search = new SqlDataAdapter(
                $"SELECT Orders.Num, Orders.orders_date, Orders.Contract_ID, Orders.Providerr, Orders.Storage," +
                $"Supply.Product_ID, Supply.NumOfProducts, Supply.Cost FROM Orders, Supply " +
                $"WHERE Orders.Contract_ID = {Convert.ToInt32(SearchField.Text)} AND Orders.Contract_ID = Supply.Contract_ID", sqlconnection);

            DataSet data = new DataSet();
            search.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }

        private void Search2_Click(object sender, EventArgs e)  // поиск по номеру товара
        {
            SqlDataAdapter search = new SqlDataAdapter(
                $"SELECT Orders.Num, Orders.orders_date, Orders.Contract_ID, Orders.Providerr, Orders.Storage," +
                $"Supply.Product_ID, Supply.NumOfProducts, Supply.Cost FROM Orders, Supply " +
                $"WHERE Supply.Product_ID = {Convert.ToInt32(SearchField2.Text)} AND Orders.Contract_ID = Supply.Contract_ID", sqlconnection);

            DataSet data = new DataSet();
            search.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }

        private void DeleteOrder_Click(object sender, EventArgs e)  //удаление заказа по номеру договора
        {
            SqlCommand delSupply = new SqlCommand($"DELETE FROM Supply WHERE " +
                $"Contract_ID = {Convert.ToInt32(SearchField.Text)}", sqlconnection);
            SqlCommand delOrder = new SqlCommand($"DELETE FROM Orders WHERE " +
                $"Contract_ID = {Convert.ToInt32(SearchField.Text)}", sqlconnection);

            int check = delSupply.ExecuteNonQuery();
            check += delOrder.ExecuteNonQuery();
            if (check == 2) MessageBox.Show("Удалено");
            else MessageBox.Show("Ошибка при удалении");
        }

        private void RefPruductsTable_Click(object sender, EventArgs e)     //обновление таблицы Products
        {
            SqlDataAdapter refresh = new SqlDataAdapter("SELECT * FROM Products", sqlconnection);

            DataSet dataset = new DataSet();
            refresh.Fill(dataset);
            ProductsTable.DataSource = dataset.Tables[0];
        }

        private void Add_Click(object sender, EventArgs e)  // Добавление товара в табл. Products
        {
            SqlCommand add = new SqlCommand($"INSERT INTO Products VALUES(@ProductsID, " +
                $"@Units, @ProductsName, @Price)", sqlconnection);

            bool ifConvert = float.TryParse(Price.Text, out float floatPrice);
            add.Parameters.AddWithValue("ProductsID", Convert.ToInt32(Product_ID.Text));
            add.Parameters.AddWithValue("Units", Units.Text);
            add.Parameters.AddWithValue("ProductsName", ProductName.Text);
            if(ifConvert) add.Parameters.AddWithValue("Price", Math.Round(floatPrice, 2));

            int check = add.ExecuteNonQuery();
            if (check == 1) MessageBox.Show("Успешно добавлено");
            else MessageBox.Show("Строка НЕ была добавлена");
        }

        private void Delete_Click(object sender, EventArgs e)   // удаление из Products по номеру договора
        {
            SqlCommand delProduct = new SqlCommand($"DELETE FROM Products WHERE" +
                $" Product_ID = @ProductID", sqlconnection);

            delProduct.Parameters.AddWithValue("ProductID", Convert.ToInt32(ProdIDForDel.Text));

            int check = delProduct.ExecuteNonQuery();
            if (check == 1) MessageBox.Show("Успешно удалено");
            else MessageBox.Show("Произошла ошибка. Данные не были удалены");
        }

    }
}
