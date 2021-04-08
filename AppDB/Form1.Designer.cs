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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfProducts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1200, 603);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Товары";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1200, 603);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1200, 603);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Поставки";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Введите номер договора";
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(239, 10);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(174, 26);
            this.SearchField.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(444, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 33);
            this.Search.TabIndex = 2;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 549);
            this.dataGridView1.TabIndex = 3;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Label label8;
    }
}

