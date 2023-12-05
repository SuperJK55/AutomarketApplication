﻿namespace kursachBD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.PartPanel = new System.Windows.Forms.Panel();
            this.PartButtonPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partShopDataSet = new kursachBD.PartShopDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new kursachBD.PartShopDataSetTableAdapters.PartsTableAdapter();
            this.codepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorypartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costpartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerpartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionpartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.PartPanel.SuspendLayout();
            this.PartButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 1041);
            this.flowLayoutPanel1.TabIndex = 9;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1617, 941);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partShopDataSet
            // 
            this.partShopDataSet.DataSetName = "PartShopDataSet";
            this.partShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.partShopDataSet;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bindingNavigator1);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1617, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(266, 33);
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
            this.button2.Location = new System.Drawing.Point(392, 33);
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
            this.button3.Location = new System.Drawing.Point(518, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.partsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.PartButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}