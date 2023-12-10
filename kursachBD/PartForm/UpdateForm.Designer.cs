namespace kursachBD
{
    partial class UpdateForm
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
            this.namePart_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typePart_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryPart_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costPart_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.manufacturerPart_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.providerParts_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descPart_textBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_comboBox = new System.Windows.Forms.ComboBox();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.PartsTableAdapter();
            this.partsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryPartsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.CategoryPartsTableAdapter();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.ManufacturerTableAdapter();
            this.providerPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerPartsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.ProviderPartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerPartsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // namePart_textBox
            // 
            this.namePart_textBox.Location = new System.Drawing.Point(129, 19);
            this.namePart_textBox.Name = "namePart_textBox";
            this.namePart_textBox.Size = new System.Drawing.Size(256, 20);
            this.namePart_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип запчасти";
            // 
            // typePart_textBox
            // 
            this.typePart_textBox.Location = new System.Drawing.Point(129, 45);
            this.typePart_textBox.Name = "typePart_textBox";
            this.typePart_textBox.Size = new System.Drawing.Size(256, 20);
            this.typePart_textBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Категория запчасти";
            // 
            // categoryPart_comboBox
            // 
            this.categoryPart_comboBox.DataSource = this.categoryPartsBindingSource;
            this.categoryPart_comboBox.DisplayMember = "Name_category";
            this.categoryPart_comboBox.FormattingEnabled = true;
            this.categoryPart_comboBox.Location = new System.Drawing.Point(129, 71);
            this.categoryPart_comboBox.Name = "categoryPart_comboBox";
            this.categoryPart_comboBox.Size = new System.Drawing.Size(256, 21);
            this.categoryPart_comboBox.TabIndex = 12;
            this.categoryPart_comboBox.ValueMember = "Code_category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            // 
            // costPart_textBox
            // 
            this.costPart_textBox.Location = new System.Drawing.Point(129, 98);
            this.costPart_textBox.Name = "costPart_textBox";
            this.costPart_textBox.Size = new System.Drawing.Size(256, 20);
            this.costPart_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Производитель";
            // 
            // manufacturerPart_comboBox
            // 
            this.manufacturerPart_comboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerPart_comboBox.DisplayMember = "Name_manufacturer";
            this.manufacturerPart_comboBox.FormattingEnabled = true;
            this.manufacturerPart_comboBox.Location = new System.Drawing.Point(129, 124);
            this.manufacturerPart_comboBox.Name = "manufacturerPart_comboBox";
            this.manufacturerPart_comboBox.Size = new System.Drawing.Size(256, 21);
            this.manufacturerPart_comboBox.TabIndex = 16;
            this.manufacturerPart_comboBox.ValueMember = "Code_manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Поставщик";
            // 
            // providerParts_comboBox
            // 
            this.providerParts_comboBox.DataSource = this.providerPartsBindingSource;
            this.providerParts_comboBox.DisplayMember = "Name_provider";
            this.providerParts_comboBox.FormattingEnabled = true;
            this.providerParts_comboBox.Location = new System.Drawing.Point(129, 151);
            this.providerParts_comboBox.Name = "providerParts_comboBox";
            this.providerParts_comboBox.Size = new System.Drawing.Size(256, 21);
            this.providerParts_comboBox.TabIndex = 18;
            this.providerParts_comboBox.ValueMember = "Code_provider";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Описание";
            // 
            // descPart_textBox
            // 
            this.descPart_textBox.Location = new System.Drawing.Point(129, 178);
            this.descPart_textBox.Multiline = true;
            this.descPart_textBox.Name = "descPart_textBox";
            this.descPart_textBox.Size = new System.Drawing.Size(256, 20);
            this.descPart_textBox.TabIndex = 20;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 241);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID";
            // 
            // ID_comboBox
            // 
            this.ID_comboBox.DataSource = this.partsBindingSource;
            this.ID_comboBox.DisplayMember = "Code_part";
            this.ID_comboBox.FormattingEnabled = true;
            this.ID_comboBox.Location = new System.Drawing.Point(129, 207);
            this.ID_comboBox.Name = "ID_comboBox";
            this.ID_comboBox.Size = new System.Drawing.Size(256, 21);
            this.ID_comboBox.TabIndex = 23;
            this.ID_comboBox.ValueMember = "Code_part";
            // 
            // partShopDataSet3
            // 
            this.partShopDataSet3.DataSetName = "PartShopDataSet3";
            this.partShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.partShopDataSet3;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // partsBindingSource1
            // 
            this.partsBindingSource1.DataMember = "Parts";
            this.partsBindingSource1.DataSource = this.partShopDataSet3;
            // 
            // partsBindingSource2
            // 
            this.partsBindingSource2.DataMember = "Parts";
            this.partsBindingSource2.DataSource = this.partShopDataSet3;
            // 
            // categoryPartsBindingSource
            // 
            this.categoryPartsBindingSource.DataMember = "CategoryParts";
            this.categoryPartsBindingSource.DataSource = this.partShopDataSet3;
            // 
            // categoryPartsTableAdapter
            // 
            this.categoryPartsTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.partShopDataSet3;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // providerPartsBindingSource
            // 
            this.providerPartsBindingSource.DataMember = "ProviderParts";
            this.providerPartsBindingSource.DataSource = this.partShopDataSet3;
            // 
            // providerPartsTableAdapter
            // 
            this.providerPartsTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 278);
            this.Controls.Add(this.ID_comboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.descPart_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.providerParts_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manufacturerPart_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costPart_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryPart_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typePart_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namePart_textBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "PartForm - Изменение записи";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerPartsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namePart_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typePart_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryPart_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costPart_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox manufacturerPart_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox providerParts_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descPart_textBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ID_comboBox;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSet3TableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource2;
        private System.Windows.Forms.BindingSource partsBindingSource1;
        private System.Windows.Forms.BindingSource categoryPartsBindingSource;
        private PartShopDataSet3TableAdapters.CategoryPartsTableAdapter categoryPartsTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private PartShopDataSet3TableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource providerPartsBindingSource;
        private PartShopDataSet3TableAdapters.ProviderPartsTableAdapter providerPartsTableAdapter;
    }
}