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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partShopDataSet1 = new kursachBD.PartShopDataSet1();
            this.categoryPartsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.manufacturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.providerPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerPartsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 178);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 20);
            this.textBox3.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryPartsBindingSource, "Code_category", true));
            this.comboBox1.DataSource = this.categoryPartsBindingSource2;
            this.comboBox1.DisplayMember = "Name_category";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Code_category";
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(256, 20);
            this.textBox4.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manufacturerBindingSource, "Code_manufacturer", true));
            this.comboBox2.DataSource = this.manufacturerBindingSource1;
            this.comboBox2.DisplayMember = "Name_manufacturer";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "Code_manufacturer";
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
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providerPartsBindingSource, "Code_provider", true));
            this.comboBox3.DataSource = this.providerPartsBindingSource1;
            this.comboBox3.DisplayMember = "Name_provider";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(129, 151);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(256, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.ValueMember = "Code_provider";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
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