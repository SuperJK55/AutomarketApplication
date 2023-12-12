namespace kursachBD.SalesForm
{
    partial class UpdateSaleForm
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
            this.IdSale_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codeBuyer_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codeSeller_comboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.BuyersTableAdapter();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.SellersTableAdapter();
            this.dateSale_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // IdSale_textBox
            // 
            this.IdSale_textBox.Location = new System.Drawing.Point(155, 19);
            this.IdSale_textBox.Name = "IdSale_textBox";
            this.IdSale_textBox.Size = new System.Drawing.Size(230, 20);
            this.IdSale_textBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Дата продажи";
            // 
            // codeBuyer_comboBox
            // 
            this.codeBuyer_comboBox.DataSource = this.buyersBindingSource;
            this.codeBuyer_comboBox.DisplayMember = "LastName_buyer";
            this.codeBuyer_comboBox.FormattingEnabled = true;
            this.codeBuyer_comboBox.Location = new System.Drawing.Point(155, 78);
            this.codeBuyer_comboBox.Name = "codeBuyer_comboBox";
            this.codeBuyer_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codeBuyer_comboBox.TabIndex = 37;
            this.codeBuyer_comboBox.ValueMember = "Code_buyer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Код покупателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Код продавца";
            // 
            // codeSeller_comboBox
            // 
            this.codeSeller_comboBox.DataSource = this.sellersBindingSource;
            this.codeSeller_comboBox.DisplayMember = "LastName_seller";
            this.codeSeller_comboBox.FormattingEnabled = true;
            this.codeSeller_comboBox.Location = new System.Drawing.Point(155, 105);
            this.codeSeller_comboBox.Name = "codeSeller_comboBox";
            this.codeSeller_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codeSeller_comboBox.TabIndex = 40;
            this.codeSeller_comboBox.ValueMember = "Code_seller";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 146);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 41;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 146);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 42;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // partShopDataSet3
            // 
            this.partShopDataSet3.DataSetName = "PartShopDataSet3";
            this.partShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.partShopDataSet3;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.partShopDataSet3;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // dateSale_dateTimePicker
            // 
            this.dateSale_dateTimePicker.Location = new System.Drawing.Point(155, 51);
            this.dateSale_dateTimePicker.Name = "dateSale_dateTimePicker";
            this.dateSale_dateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dateSale_dateTimePicker.TabIndex = 43;
            // 
            // UpdateSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 183);
            this.Controls.Add(this.dateSale_dateTimePicker);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.codeSeller_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeBuyer_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdSale_textBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSaleForm";
            this.Text = "UpdateSaleForm";
            this.Load += new System.EventHandler(this.UpdateSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdSale_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox codeBuyer_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox codeSeller_comboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClosedButton;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private PartShopDataSet3TableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private PartShopDataSet3TableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.DateTimePicker dateSale_dateTimePicker;
    }
}