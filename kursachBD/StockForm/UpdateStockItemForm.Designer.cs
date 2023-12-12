namespace kursachBD.StockForm
{
    partial class UpdateStockItemForm
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
            this.IdStockItem_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countParts_textBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.codePart_comboBox = new System.Windows.Forms.ComboBox();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.PartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // IdStockItem_textBox
            // 
            this.IdStockItem_textBox.Location = new System.Drawing.Point(155, 19);
            this.IdStockItem_textBox.Name = "IdStockItem_textBox";
            this.IdStockItem_textBox.Size = new System.Drawing.Size(230, 20);
            this.IdStockItem_textBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Код запчасти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Количество запчастей";
            // 
            // countParts_textBox
            // 
            this.countParts_textBox.Location = new System.Drawing.Point(155, 78);
            this.countParts_textBox.Name = "countParts_textBox";
            this.countParts_textBox.Size = new System.Drawing.Size(230, 20);
            this.countParts_textBox.TabIndex = 38;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 133);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 39;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 133);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 40;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // codePart_comboBox
            // 
            this.codePart_comboBox.DataSource = this.partsBindingSource;
            this.codePart_comboBox.DisplayMember = "Name_part";
            this.codePart_comboBox.FormattingEnabled = true;
            this.codePart_comboBox.Location = new System.Drawing.Point(155, 47);
            this.codePart_comboBox.Name = "codePart_comboBox";
            this.codePart_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codePart_comboBox.TabIndex = 41;
            this.codePart_comboBox.ValueMember = "Code_part";
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
            // UpdateStockItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 170);
            this.Controls.Add(this.codePart_comboBox);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.countParts_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdStockItem_textBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateStockItemForm";
            this.Text = "UpdateStockItemForm";
            this.Load += new System.EventHandler(this.UpdateStockItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdStockItem_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countParts_textBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.ComboBox codePart_comboBox;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSet3TableAdapters.PartsTableAdapter partsTableAdapter;
    }
}