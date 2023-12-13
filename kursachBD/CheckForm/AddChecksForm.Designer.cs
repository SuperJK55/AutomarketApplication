namespace kursachBD.Check
{
    partial class AddChecksForm
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
            this.ClosedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountSalelsItem_textBox = new System.Windows.Forms.TextBox();
            this.codePart_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeSales_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.SalesTableAdapter();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.PartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 153);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 42;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 153);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 25);
            this.AddButton.TabIndex = 41;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Количество позиций";
            // 
            // amountSalelsItem_textBox
            // 
            this.amountSalelsItem_textBox.Location = new System.Drawing.Point(155, 74);
            this.amountSalelsItem_textBox.Name = "amountSalelsItem_textBox";
            this.amountSalelsItem_textBox.Size = new System.Drawing.Size(230, 20);
            this.amountSalelsItem_textBox.TabIndex = 39;
            // 
            // codePart_comboBox
            // 
            this.codePart_comboBox.DataSource = this.partsBindingSource;
            this.codePart_comboBox.DisplayMember = "Name_part";
            this.codePart_comboBox.FormattingEnabled = true;
            this.codePart_comboBox.Location = new System.Drawing.Point(155, 45);
            this.codePart_comboBox.Name = "codePart_comboBox";
            this.codePart_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codePart_comboBox.TabIndex = 38;
            this.codePart_comboBox.ValueMember = "Code_part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Код запчасти";
            // 
            // codeSales_comboBox
            // 
            this.codeSales_comboBox.DataSource = this.salesBindingSource;
            this.codeSales_comboBox.DisplayMember = "Code_sales";
            this.codeSales_comboBox.FormattingEnabled = true;
            this.codeSales_comboBox.Location = new System.Drawing.Point(155, 16);
            this.codeSales_comboBox.Name = "codeSales_comboBox";
            this.codeSales_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codeSales_comboBox.TabIndex = 36;
            this.codeSales_comboBox.ValueMember = "Code_sales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Код продажи";
            // 
            // partShopDataSet3
            // 
            this.partShopDataSet3.DataSetName = "PartShopDataSet3";
            this.partShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.partShopDataSet3;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
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
            // AddChecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 193);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountSalelsItem_textBox);
            this.Controls.Add(this.codePart_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeSales_comboBox);
            this.Controls.Add(this.label6);
            this.Name = "AddChecksForm";
            this.Text = "AddChecksForm";
            this.Load += new System.EventHandler(this.AddChecksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountSalelsItem_textBox;
        private System.Windows.Forms.ComboBox codePart_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox codeSales_comboBox;
        private System.Windows.Forms.Label label6;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private PartShopDataSet3TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSet3TableAdapters.PartsTableAdapter partsTableAdapter;
    }
}