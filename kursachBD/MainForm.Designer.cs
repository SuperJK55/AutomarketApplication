namespace kursachBD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PartsButton = new System.Windows.Forms.Button();
            this.CategoryPartsButton = new System.Windows.Forms.Button();
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.ProviderButton = new System.Windows.Forms.Button();
            this.StockButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.ChecksButton = new System.Windows.Forms.Button();
            this.BuyersButton = new System.Windows.Forms.Button();
            this.SellersButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.PartPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorypartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costpartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerpartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionpartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partShopDataSet = new kursachBD.PartShopDataSet();
            this.PartButtonPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.partsTableAdapter = new kursachBD.PartShopDataSetTableAdapters.PartsTableAdapter();
            this.endProgramButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.PartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet)).BeginInit();
            this.PartButtonPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartsButton
            // 
            this.PartsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PartsButton.Location = new System.Drawing.Point(3, 3);
            this.PartsButton.Name = "PartsButton";
            this.PartsButton.Size = new System.Drawing.Size(259, 56);
            this.PartsButton.TabIndex = 0;
            this.PartsButton.Text = "Список запчастей";
            this.PartsButton.UseVisualStyleBackColor = true;
            this.PartsButton.Click += new System.EventHandler(this.PartsButton_Click);
            // 
            // CategoryPartsButton
            // 
            this.CategoryPartsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryPartsButton.Location = new System.Drawing.Point(3, 65);
            this.CategoryPartsButton.Name = "CategoryPartsButton";
            this.CategoryPartsButton.Size = new System.Drawing.Size(259, 56);
            this.CategoryPartsButton.TabIndex = 1;
            this.CategoryPartsButton.Text = "Категории запчастей";
            this.CategoryPartsButton.UseVisualStyleBackColor = true;
            this.CategoryPartsButton.Click += new System.EventHandler(this.CategoryPartsButton_Click);
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManufacturerButton.Location = new System.Drawing.Point(3, 127);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(259, 56);
            this.ManufacturerButton.TabIndex = 2;
            this.ManufacturerButton.Text = "Производители запчастей";
            this.ManufacturerButton.UseVisualStyleBackColor = true;
            this.ManufacturerButton.Click += new System.EventHandler(this.ManufacturerButton_Click);
            // 
            // ProviderButton
            // 
            this.ProviderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProviderButton.Location = new System.Drawing.Point(3, 189);
            this.ProviderButton.Name = "ProviderButton";
            this.ProviderButton.Size = new System.Drawing.Size(259, 56);
            this.ProviderButton.TabIndex = 3;
            this.ProviderButton.Text = "Поставщики запчастей";
            this.ProviderButton.UseVisualStyleBackColor = true;
            this.ProviderButton.Click += new System.EventHandler(this.ProviderButton_Click);
            // 
            // StockButton
            // 
            this.StockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockButton.Location = new System.Drawing.Point(3, 251);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(259, 56);
            this.StockButton.TabIndex = 4;
            this.StockButton.Text = "Склад";
            this.StockButton.UseVisualStyleBackColor = true;
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesButton.Location = new System.Drawing.Point(3, 313);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(259, 56);
            this.SalesButton.TabIndex = 5;
            this.SalesButton.Text = "Продажи";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ChecksButton
            // 
            this.ChecksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChecksButton.Location = new System.Drawing.Point(3, 375);
            this.ChecksButton.Name = "ChecksButton";
            this.ChecksButton.Size = new System.Drawing.Size(259, 56);
            this.ChecksButton.TabIndex = 6;
            this.ChecksButton.Text = "Чеки";
            this.ChecksButton.UseVisualStyleBackColor = true;
            this.ChecksButton.Click += new System.EventHandler(this.ChecksButton_Click);
            // 
            // BuyersButton
            // 
            this.BuyersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyersButton.Location = new System.Drawing.Point(3, 437);
            this.BuyersButton.Name = "BuyersButton";
            this.BuyersButton.Size = new System.Drawing.Size(259, 56);
            this.BuyersButton.TabIndex = 7;
            this.BuyersButton.Text = "Покупатели";
            this.BuyersButton.UseVisualStyleBackColor = true;
            this.BuyersButton.Click += new System.EventHandler(this.BuyersButton_Click);
            // 
            // SellersButton
            // 
            this.SellersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellersButton.Location = new System.Drawing.Point(3, 499);
            this.SellersButton.Name = "SellersButton";
            this.SellersButton.Size = new System.Drawing.Size(259, 56);
            this.SellersButton.TabIndex = 8;
            this.SellersButton.Text = "Продавцы";
            this.SellersButton.UseVisualStyleBackColor = true;
            this.SellersButton.Click += new System.EventHandler(this.SellersButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PartsButton);
            this.flowLayoutPanel1.Controls.Add(this.CategoryPartsButton);
            this.flowLayoutPanel1.Controls.Add(this.ManufacturerButton);
            this.flowLayoutPanel1.Controls.Add(this.ProviderButton);
            this.flowLayoutPanel1.Controls.Add(this.StockButton);
            this.flowLayoutPanel1.Controls.Add(this.SalesButton);
            this.flowLayoutPanel1.Controls.Add(this.ChecksButton);
            this.flowLayoutPanel1.Controls.Add(this.BuyersButton);
            this.flowLayoutPanel1.Controls.Add(this.SellersButton);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Controls.Add(this.endProgramButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 1041);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(3, 561);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(259, 56);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Выход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // PartPanel
            // 
            this.PartPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PartPanel.Controls.Add(this.dataGridView1);
            this.PartPanel.Controls.Add(this.PartButtonPanel);
            this.PartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartPanel.Location = new System.Drawing.Point(287, 0);
            this.PartPanel.Name = "PartPanel";
            this.PartPanel.Size = new System.Drawing.Size(1617, 1041);
            this.PartPanel.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepartDataGridViewTextBoxColumn,
            this.namepartDataGridViewTextBoxColumn,
            this.typepartDataGridViewTextBoxColumn,
            this.categorypartDataGridViewTextBoxColumn,
            this.costpartDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.providerpartsDataGridViewTextBoxColumn,
            this.descriptionpartDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(1617, 941);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codepartDataGridViewTextBoxColumn
            // 
            this.codepartDataGridViewTextBoxColumn.DataPropertyName = "Code_part";
            this.codepartDataGridViewTextBoxColumn.HeaderText = "Код запчасти";
            this.codepartDataGridViewTextBoxColumn.Name = "codepartDataGridViewTextBoxColumn";
            this.codepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namepartDataGridViewTextBoxColumn
            // 
            this.namepartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namepartDataGridViewTextBoxColumn.DataPropertyName = "Name_part";
            this.namepartDataGridViewTextBoxColumn.HeaderText = "Название запчасти";
            this.namepartDataGridViewTextBoxColumn.Name = "namepartDataGridViewTextBoxColumn";
            // 
            // typepartDataGridViewTextBoxColumn
            // 
            this.typepartDataGridViewTextBoxColumn.DataPropertyName = "Type_part";
            this.typepartDataGridViewTextBoxColumn.HeaderText = "Тип запчасти";
            this.typepartDataGridViewTextBoxColumn.Name = "typepartDataGridViewTextBoxColumn";
            // 
            // categorypartDataGridViewTextBoxColumn
            // 
            this.categorypartDataGridViewTextBoxColumn.DataPropertyName = "Category_part";
            this.categorypartDataGridViewTextBoxColumn.HeaderText = "Категория запчасти";
            this.categorypartDataGridViewTextBoxColumn.Name = "categorypartDataGridViewTextBoxColumn";
            // 
            // costpartDataGridViewTextBoxColumn
            // 
            this.costpartDataGridViewTextBoxColumn.DataPropertyName = "Cost_part";
            this.costpartDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costpartDataGridViewTextBoxColumn.Name = "costpartDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // providerpartsDataGridViewTextBoxColumn
            // 
            this.providerpartsDataGridViewTextBoxColumn.DataPropertyName = "Provider_parts";
            this.providerpartsDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.providerpartsDataGridViewTextBoxColumn.Name = "providerpartsDataGridViewTextBoxColumn";
            // 
            // descriptionpartDataGridViewTextBoxColumn
            // 
            this.descriptionpartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionpartDataGridViewTextBoxColumn.DataPropertyName = "Description_part";
            this.descriptionpartDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionpartDataGridViewTextBoxColumn.Name = "descriptionpartDataGridViewTextBoxColumn";
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.partShopDataSet;
            // 
            // partShopDataSet
            // 
            this.partShopDataSet.DataSetName = "PartShopDataSet";
            this.partShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PartButtonPanel
            // 
            this.PartButtonPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PartButtonPanel.Controls.Add(this.flowLayoutPanel2);
            this.PartButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PartButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.PartButtonPanel.Name = "PartButtonPanel";
            this.PartButtonPanel.Size = new System.Drawing.Size(1617, 100);
            this.PartButtonPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.updateTableButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1617, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(3, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(129, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(255, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateTableButton
            // 
            this.updateTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTableButton.Location = new System.Drawing.Point(381, 33);
            this.updateTableButton.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(120, 34);
            this.updateTableButton.TabIndex = 3;
            this.updateTableButton.Text = "Обновить";
            this.updateTableButton.UseVisualStyleBackColor = true;
            this.updateTableButton.Click += new System.EventHandler(this.updateTableButton_Click);
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // endProgramButton
            // 
            this.endProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endProgramButton.Location = new System.Drawing.Point(3, 623);
            this.endProgramButton.Name = "endProgramButton";
            this.endProgramButton.Size = new System.Drawing.Size(259, 56);
            this.endProgramButton.TabIndex = 10;
            this.endProgramButton.Text = "Завершить работу приложения";
            this.endProgramButton.UseVisualStyleBackColor = true;
            this.endProgramButton.Click += new System.EventHandler(this.endProgramButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PartPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "PartShop - Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet)).EndInit();
            this.PartButtonPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PartsButton;
        private System.Windows.Forms.Button CategoryPartsButton;
        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Button ProviderButton;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button ChecksButton;
        private System.Windows.Forms.Button BuyersButton;
        private System.Windows.Forms.Button SellersButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PartPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PartButtonPanel;
        private PartShopDataSet partShopDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorypartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costpartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerpartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionpartDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button updateTableButton;
        private System.Windows.Forms.Button endProgramButton;
    }
}