namespace kursachBD
{
    partial class AddPartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.namePart_textBox = new System.Windows.Forms.TextBox();
            this.descPart_textBox = new System.Windows.Forms.TextBox();
            this.typePart_textBox = new System.Windows.Forms.TextBox();
            this.categoryPart_comboBox = new System.Windows.Forms.ComboBox();
            this.categoryPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partShopDataSet1 = new kursachBD.PartShopDataSet1();
            this.categoryPartsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.costPart_textBox = new System.Windows.Forms.TextBox();
            this.manufacturerPart_comboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.manufacturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.providerParts_comboBox = new System.Windows.Forms.ComboBox();
            this.providerPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerPartsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.InsertButton = new System.Windows.Forms.Button();
            this.partShopDataSet = new kursachBD.PartShopDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new kursachBD.PartShopDataSetTableAdapters.PartsTableAdapter();
            this.categoryPartsTableAdapter = new kursachBD.PartShopDataSet1TableAdapters.CategoryPartsTableAdapter();
            this.categoryPartsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.ManufacturerTableAdapter();
            this.providerPartsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.ProviderPartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerPartsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип запчасти";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория запчасти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Производитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Описание";
            // 
            // namePart_textBox
            // 
            this.namePart_textBox.Location = new System.Drawing.Point(129, 19);
            this.namePart_textBox.Name = "namePart_textBox";
            this.namePart_textBox.Size = new System.Drawing.Size(256, 20);
            this.namePart_textBox.TabIndex = 7;
            // 
            // descPart_textBox
            // 
            this.descPart_textBox.Location = new System.Drawing.Point(129, 178);
            this.descPart_textBox.Multiline = true;
            this.descPart_textBox.Name = "descPart_textBox";
            this.descPart_textBox.Size = new System.Drawing.Size(256, 20);
            this.descPart_textBox.TabIndex = 8;
            // 
            // typePart_textBox
            // 
            this.typePart_textBox.Location = new System.Drawing.Point(129, 45);
            this.typePart_textBox.Name = "typePart_textBox";
            this.typePart_textBox.Size = new System.Drawing.Size(256, 20);
            this.typePart_textBox.TabIndex = 9;
            // 
            // categoryPart_comboBox
            // 
            this.categoryPart_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryPartsBindingSource, "Code_category", true));
            this.categoryPart_comboBox.DataSource = this.categoryPartsBindingSource2;
            this.categoryPart_comboBox.DisplayMember = "Name_category";
            this.categoryPart_comboBox.FormattingEnabled = true;
            this.categoryPart_comboBox.Location = new System.Drawing.Point(129, 71);
            this.categoryPart_comboBox.Name = "categoryPart_comboBox";
            this.categoryPart_comboBox.Size = new System.Drawing.Size(256, 21);
            this.categoryPart_comboBox.TabIndex = 10;
            this.categoryPart_comboBox.ValueMember = "Code_category";
            // 
            // categoryPartsBindingSource
            // 
            this.categoryPartsBindingSource.DataMember = "CategoryParts";
            this.categoryPartsBindingSource.DataSource = this.partShopDataSet1;
            // 
            // partShopDataSet1
            // 
            this.partShopDataSet1.DataSetName = "PartShopDataSet1";
            this.partShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryPartsBindingSource2
            // 
            this.categoryPartsBindingSource2.DataMember = "CategoryParts";
            this.categoryPartsBindingSource2.DataSource = this.partShopDataSet1;
            // 
            // costPart_textBox
            // 
            this.costPart_textBox.Location = new System.Drawing.Point(129, 98);
            this.costPart_textBox.Name = "costPart_textBox";
            this.costPart_textBox.Size = new System.Drawing.Size(256, 20);
            this.costPart_textBox.TabIndex = 11;
            // 
            // manufacturerPart_comboBox
            // 
            this.manufacturerPart_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manufacturerBindingSource, "Code_manufacturer", true));
            this.manufacturerPart_comboBox.DataSource = this.manufacturerBindingSource1;
            this.manufacturerPart_comboBox.DisplayMember = "Name_manufacturer";
            this.manufacturerPart_comboBox.FormattingEnabled = true;
            this.manufacturerPart_comboBox.Location = new System.Drawing.Point(129, 124);
            this.manufacturerPart_comboBox.Name = "manufacturerPart_comboBox";
            this.manufacturerPart_comboBox.Size = new System.Drawing.Size(256, 21);
            this.manufacturerPart_comboBox.TabIndex = 12;
            this.manufacturerPart_comboBox.ValueMember = "Code_manufacturer";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.partShopDataSet3;
            // 
            // partShopDataSet3
            // 
            this.partShopDataSet3.DataSetName = "PartShopDataSet3";
            this.partShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerBindingSource1
            // 
            this.manufacturerBindingSource1.DataMember = "Manufacturer";
            this.manufacturerBindingSource1.DataSource = this.partShopDataSet3;
            // 
            // providerParts_comboBox
            // 
            this.providerParts_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providerPartsBindingSource, "Code_provider", true));
            this.providerParts_comboBox.DataSource = this.providerPartsBindingSource1;
            this.providerParts_comboBox.DisplayMember = "Name_provider";
            this.providerParts_comboBox.FormattingEnabled = true;
            this.providerParts_comboBox.Location = new System.Drawing.Point(129, 151);
            this.providerParts_comboBox.Name = "providerParts_comboBox";
            this.providerParts_comboBox.Size = new System.Drawing.Size(256, 21);
            this.providerParts_comboBox.TabIndex = 13;
            this.providerParts_comboBox.ValueMember = "Code_provider";
            // 
            // providerPartsBindingSource
            // 
            this.providerPartsBindingSource.DataMember = "ProviderParts";
            this.providerPartsBindingSource.DataSource = this.partShopDataSet3;
            // 
            // providerPartsBindingSource1
            // 
            this.providerPartsBindingSource1.DataMember = "ProviderParts";
            this.providerPartsBindingSource1.DataSource = this.partShopDataSet3;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(241, 210);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(144, 56);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
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
            // categoryPartsTableAdapter
            // 
            this.categoryPartsTableAdapter.ClearBeforeFill = true;
            // 
            // categoryPartsBindingSource1
            // 
            this.categoryPartsBindingSource1.DataMember = "CategoryParts";
            this.categoryPartsBindingSource1.DataSource = this.partShopDataSet1;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // providerPartsTableAdapter
            // 
            this.providerPartsTableAdapter.ClearBeforeFill = true;
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 278);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.providerParts_comboBox);
            this.Controls.Add(this.manufacturerPart_comboBox);
            this.Controls.Add(this.costPart_textBox);
            this.Controls.Add(this.categoryPart_comboBox);
            this.Controls.Add(this.typePart_textBox);
            this.Controls.Add(this.descPart_textBox);
            this.Controls.Add(this.namePart_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "PartForm - Добавление запчасти";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerPartsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox namePart_textBox;
        private System.Windows.Forms.TextBox descPart_textBox;
        private System.Windows.Forms.TextBox typePart_textBox;
        private System.Windows.Forms.ComboBox categoryPart_comboBox;
        private System.Windows.Forms.TextBox costPart_textBox;
        private System.Windows.Forms.ComboBox manufacturerPart_comboBox;
        private System.Windows.Forms.ComboBox providerParts_comboBox;
        private System.Windows.Forms.Button InsertButton;
        private PartShopDataSet partShopDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private PartShopDataSet1 partShopDataSet1;
        private System.Windows.Forms.BindingSource categoryPartsBindingSource;
        private PartShopDataSet1TableAdapters.CategoryPartsTableAdapter categoryPartsTableAdapter;
        private System.Windows.Forms.BindingSource categoryPartsBindingSource2;
        private System.Windows.Forms.BindingSource categoryPartsBindingSource1;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private PartShopDataSet3TableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource1;
        private System.Windows.Forms.BindingSource providerPartsBindingSource;
        private PartShopDataSet3TableAdapters.ProviderPartsTableAdapter providerPartsTableAdapter;
        private System.Windows.Forms.BindingSource providerPartsBindingSource1;
    }
}