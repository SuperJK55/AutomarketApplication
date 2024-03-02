namespace kursachBD.SalesForm
{
    partial class AddSaleForm
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
            this.dateSale_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.codeSeller_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codeBuyer_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.BuyersTableAdapter();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.SellersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateSale_dateTimePicker
            // 
            this.dateSale_dateTimePicker.Location = new System.Drawing.Point(155, 18);
            this.dateSale_dateTimePicker.Name = "dateSale_dateTimePicker";
            this.dateSale_dateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dateSale_dateTimePicker.TabIndex = 51;
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 146);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 50;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 146);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 25);
            this.AddButton.TabIndex = 49;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // codeSeller_comboBox
            // 
            this.codeSeller_comboBox.DataSource = this.sellersBindingSource;
            this.codeSeller_comboBox.DisplayMember = "LastName_seller";
            this.codeSeller_comboBox.FormattingEnabled = true;
            this.codeSeller_comboBox.Location = new System.Drawing.Point(155, 72);
            this.codeSeller_comboBox.Name = "codeSeller_comboBox";
            this.codeSeller_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codeSeller_comboBox.TabIndex = 48;
            this.codeSeller_comboBox.ValueMember = "Code_seller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Код продавца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Код покупателя";
            // 
            // codeBuyer_comboBox
            // 
            this.codeBuyer_comboBox.DataSource = this.buyersBindingSource;
            this.codeBuyer_comboBox.DisplayMember = "LastName_buyer";
            this.codeBuyer_comboBox.FormattingEnabled = true;
            this.codeBuyer_comboBox.Location = new System.Drawing.Point(155, 45);
            this.codeBuyer_comboBox.Name = "codeBuyer_comboBox";
            this.codeBuyer_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codeBuyer_comboBox.TabIndex = 45;
            this.codeBuyer_comboBox.ValueMember = "Code_buyer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Дата продажи";
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
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 183);
            this.Controls.Add(this.dateSale_dateTimePicker);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.codeSeller_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeBuyer_comboBox);
            this.Controls.Add(this.label6);
            this.Name = "AddSaleForm";
            this.Text = "AddSaleForm";
            this.Load += new System.EventHandler(this.AddSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateSale_dateTimePicker;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox codeSeller_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox codeBuyer_comboBox;
        private System.Windows.Forms.Label label6;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private PartShopDataSet3TableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private PartShopDataSet3TableAdapters.SellersTableAdapter sellersTableAdapter;
    }
}