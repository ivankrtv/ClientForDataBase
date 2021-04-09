namespace AppDB
{
    partial class ClientDB
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numOfProducts = new System.Windows.Forms.NumericUpDown();
            this.Insert_new = new System.Windows.Forms.Button();
            this.ProductsID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Storage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Provider = new System.Windows.Forms.TextBox();
            this.ContractID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search2 = new System.Windows.Forms.Button();
            this.SearchField2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.ProdIDForDel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Units = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RefPruductsTable = new System.Windows.Forms.Button();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.RefreshOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfProducts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.num);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numOfProducts);
            this.tabPage1.Controls.Add(this.Insert_new);
            this.tabPage1.Controls.Add(this.ProductsID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Date);
            this.tabPage1.Controls.Add(this.Storage);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Provider);
            this.tabPage1.Controls.Add(this.ContractID);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новая поставка";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(285, 28);
            this.num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(152, 26);
            this.num.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Номер поставки";
            // 
            // numOfProducts
            // 
            this.numOfProducts.Location = new System.Drawing.Point(285, 251);
            this.numOfProducts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOfProducts.Name = "numOfProducts";
            this.numOfProducts.Size = new System.Drawing.Size(152, 26);
            this.numOfProducts.TabIndex = 16;
            // 
            // Insert_new
            // 
            this.Insert_new.BackColor = System.Drawing.Color.Gainsboro;
            this.Insert_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Insert_new.Location = new System.Drawing.Point(285, 387);
            this.Insert_new.Name = "Insert_new";
            this.Insert_new.Size = new System.Drawing.Size(184, 41);
            this.Insert_new.TabIndex = 15;
            this.Insert_new.Text = "Добавить";
            this.Insert_new.UseVisualStyleBackColor = false;
            this.Insert_new.Click += new System.EventHandler(this.Insert_new_Click);
            // 
            // ProductsID
            // 
            this.ProductsID.Location = new System.Drawing.Point(285, 298);
            this.ProductsID.Name = "ProductsID";
            this.ProductsID.Size = new System.Drawing.Size(194, 26);
            this.ProductsID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Наменклотурный номер товара";
            // 
            // Date
            // 
            this.Date.CustomFormat = "";
            this.Date.Location = new System.Drawing.Point(285, 205);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 26);
            this.Date.TabIndex = 12;
            this.Date.Value = new System.DateTime(2021, 4, 8, 21, 4, 33, 0);
            // 
            // Storage
            // 
            this.Storage.Location = new System.Drawing.Point(285, 162);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(285, 26);
            this.Storage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата поставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Место хранения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поставщик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер договора поставки";
            // 
            // Provider
            // 
            this.Provider.Location = new System.Drawing.Point(285, 116);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(285, 26);
            this.Provider.TabIndex = 2;
            // 
            // ContractID
            // 
            this.ContractID.Location = new System.Drawing.Point(285, 71);
            this.ContractID.Name = "ContractID";
            this.ContractID.Size = new System.Drawing.Size(200, 26);
            this.ContractID.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.RefreshOrder);
            this.tabPage2.Controls.Add(this.Search2);
            this.tabPage2.Controls.Add(this.SearchField2);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.DeleteOrder);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.Search);
            this.tabPage2.Controls.Add(this.SearchField);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Найти";
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(353, 46);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 33);
            this.Search2.TabIndex = 8;
            this.Search2.Text = "Найти";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // SearchField2
            // 
            this.SearchField2.Location = new System.Drawing.Point(161, 49);
            this.SearchField2.Name = "SearchField2";
            this.SearchField2.Size = new System.Drawing.Size(174, 26);
            this.SearchField2.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Номер товара";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(720, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Удалить заказ с этим номером договора";
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(1049, 10);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(103, 29);
            this.DeleteOrder.TabIndex = 4;
            this.DeleteOrder.Text = "Удалить";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 509);
            this.dataGridView1.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(353, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 33);
            this.Search.TabIndex = 2;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(161, 10);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(174, 26);
            this.SearchField.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Номер договора";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.Delete);
            this.tabPage4.Controls.Add(this.ProdIDForDel);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.Add);
            this.tabPage4.Controls.Add(this.Price);
            this.tabPage4.Controls.Add(this.Label);
            this.tabPage4.Controls.Add(this.ProductName);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.Units);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.Product_ID);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.RefPruductsTable);
            this.tabPage4.Controls.Add(this.ProductsTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1200, 603);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Товары";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(514, 493);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "разделять запятой)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(492, 473);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "(целая и десятичная часть ";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(177, 536);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 34);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ProdIDForDel
            // 
            this.ProdIDForDel.Location = new System.Drawing.Point(12, 540);
            this.ProdIDForDel.Name = "ProdIDForDel";
            this.ProdIDForDel.Size = new System.Drawing.Size(129, 26);
            this.ProdIDForDel.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Номер товара";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Удалить товар:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(694, 440);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(111, 34);
            this.Add.TabIndex = 11;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(518, 444);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(129, 26);
            this.Price.TabIndex = 10;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(514, 420);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(136, 20);
            this.Label.TabIndex = 9;
            this.Label.Text = "Цена за единицу";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(317, 444);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(176, 26);
            this.ProductName.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Наименование товара";
            // 
            // Units
            // 
            this.Units.Location = new System.Drawing.Point(163, 444);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(129, 26);
            this.Units.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Единицы товара";
            // 
            // Product_ID
            // 
            this.Product_ID.Location = new System.Drawing.Point(8, 444);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Size = new System.Drawing.Size(129, 26);
            this.Product_ID.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Номер товара";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Добавить товар:";
            // 
            // RefPruductsTable
            // 
            this.RefPruductsTable.Location = new System.Drawing.Point(1079, 387);
            this.RefPruductsTable.Name = "RefPruductsTable";
            this.RefPruductsTable.Size = new System.Drawing.Size(113, 35);
            this.RefPruductsTable.TabIndex = 1;
            this.RefPruductsTable.Text = "Обновить";
            this.RefPruductsTable.UseVisualStyleBackColor = true;
            this.RefPruductsTable.Click += new System.EventHandler(this.RefPruductsTable_Click);
            // 
            // ProductsTable
            // 
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Location = new System.Drawing.Point(8, 3);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.RowHeadersWidth = 62;
            this.ProductsTable.RowTemplate.Height = 28;
            this.ProductsTable.Size = new System.Drawing.Size(1184, 378);
            this.ProductsTable.TabIndex = 0;
            // 
            // RefreshOrder
            // 
            this.RefreshOrder.Location = new System.Drawing.Point(521, 37);
            this.RefreshOrder.Name = "RefreshOrder";
            this.RefreshOrder.Size = new System.Drawing.Size(111, 40);
            this.RefreshOrder.TabIndex = 9;
            this.RefreshOrder.Text = "Обновить";
            this.RefreshOrder.UseVisualStyleBackColor = true;
            this.RefreshOrder.Click += new System.EventHandler(this.RefreshOrder_Click);
            // 
            // ClientDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 636);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientDB";
            this.Text = "ClientDB";
            this.Load += new System.EventHandler(this.ClientDB_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfProducts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Insert_new;
        private System.Windows.Forms.TextBox ProductsID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Storage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Provider;
        private System.Windows.Forms.TextBox ContractID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numOfProducts;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ProductsTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button RefPruductsTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Units;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox ProdIDForDel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.TextBox SearchField2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button RefreshOrder;
    }
}

