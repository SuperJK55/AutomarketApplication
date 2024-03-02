namespace kursachBD.StockForm
{
    partial class AddStockItemForm
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
            this.codePart_comboBox = new System.Windows.Forms.ComboBox();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.countParts_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.PartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codePart_comboBox
            // 
            this.codePart_comboBox.DataSource = this.partsBindingSource;
            this.codePart_comboBox.DisplayMember = "Name_part";
            this.codePart_comboBox.FormattingEnabled = true;
            this.codePart_comboBox.Location = new System.Drawing.Point(155, 12);
            this.codePart_comboBox.Name = "codePart_comboBox";
            this.codePart_comboBox.Size = new System.Drawing.Size(230, 21);
            this.codePart_comboBox.TabIndex = 47;
            this.codePart_comboBox.ValueMember = "Code_part";
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 98);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 46;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 98);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 25);
            this.AddButton.TabIndex = 45;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // countParts_textBox
            // 
            this.countParts_textBox.Location = new System.Drawing.Point(155, 43);
            this.countParts_textBox.Name = "countParts_textBox";
            this.countParts_textBox.Size = new System.Drawing.Size(230, 20);
            this.countParts_textBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Количество запчастей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Код запчасти";
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
            // AddStockItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 137);
            this.Controls.Add(this.codePart_comboBox);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.countParts_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "AddStockItemForm";
            this.Text = "AddStockItemForm";
            this.Load += new System.EventHandler(this.AddStockItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox codePart_comboBox;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox countParts_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private PartShopDataSet3TableAdapters.PartsTableAdapter partsTableAdapter;
    }
}