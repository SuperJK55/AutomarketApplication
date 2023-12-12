namespace kursachBD.Check
{
    partial class UpdateChecksForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.IdSalesItem_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codeSales_comboBox = new System.Windows.Forms.ComboBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.codePart_comboBox = new System.Windows.Forms.ComboBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountSalelsItem_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salesTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.SalesTableAdapter();
            this.partsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.PartsTableAdapter();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClosedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID";
            // 
            // IdSalesItem_textBox
            // 
            this.IdSalesItem_textBox.Location = new System.Drawing.Point(155, 19);
            this.IdSalesItem_textBox.Name = "IdSalesItem_textBox";
            this.IdSalesItem_textBox.Size = new System.Drawing.Size(230, 20);
            this.IdSalesItem_textBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Код продажи";
            // 
            // codeSales_comboBox
            // 
            this.codeSales_comboBox.DataSource = this.salesBindingSource;
            this.codeSales_comboBox.DisplayMember = "Code_sales";
            this.codeSales_comboBox.FormattingEnabled = true;
            this.codeSales_comboBox.Location = new System.Drawing.Point(155, 49);
            this.codeSales_comboBox.Name = "codeSales_comboBox";
            this.codeSales_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codeSales_comboBox.TabIndex = 28;
            this.codeSales_comboBox.ValueMember = "Code_sales";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.partShopDataSet3;
            // 
            // partShopDataSet3
            // 
            this.partShopDataSet3.DataSetName = "PartShopDataSet3";
            this.partShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Код запчасти";
            // 
            // codePart_comboBox
            // 
            this.codePart_comboBox.DataSource = this.partsBindingSource;
            this.codePart_comboBox.DisplayMember = "Name_part";
            this.codePart_comboBox.FormattingEnabled = true;
            this.codePart_comboBox.Location = new System.Drawing.Point(155, 78);
            this.codePart_comboBox.Name = "codePart_comboBox";
            this.codePart_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codePart_comboBox.TabIndex = 30;
            this.codePart_comboBox.ValueMember = "Code_part";
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.partShopDataSet3;
            // 
            // amountSalelsItem_textBox
            // 
            this.amountSalelsItem_textBox.Location = new System.Drawing.Point(155, 107);
            this.amountSalelsItem_textBox.Name = "amountSalelsItem_textBox";
            this.amountSalelsItem_textBox.Size = new System.Drawing.Size(230, 20);
            this.amountSalelsItem_textBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Количество позиций";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 186);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 33;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 186);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 34;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // UpdateChecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 223);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountSalelsItem_textBox);
            this.Controls.Add(this.codePart_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeSales_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdSalesItem_textBox);
            this.Controls.Add(this.label8);
            this.Name = "UpdateChecksForm";
            this.Text = "UpdateChecksForm";
            this.Load += new System.EventHandler(this.UpdateChecksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdSalesItem_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox codeSales_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox codePart_comboBox;
        private System.Windows.Forms.TextBox amountSalelsItem_textBox;
        private System.Windows.Forms.Label label2;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private PartShopDataSet3TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSet3TableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClosedButton;
    }
}