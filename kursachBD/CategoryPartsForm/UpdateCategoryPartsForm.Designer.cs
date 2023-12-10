namespace kursachBD.CategoryPartsForm
{
    partial class UpdateCategoryPartsForm
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
            this.ID_comboBox = new System.Windows.Forms.ComboBox();
            this.partShopDataSet3 = new kursachBD.PartShopDataSet3();
            this.categoryPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryPartsTableAdapter = new kursachBD.PartShopDataSet3TableAdapters.CategoryPartsTableAdapter();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.categoryPartsName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID";
            // 
            // ID_comboBox
            // 
            this.ID_comboBox.DataSource = this.categoryPartsBindingSource;
            this.ID_comboBox.DisplayMember = "Code_category";
            this.ID_comboBox.FormattingEnabled = true;
            this.ID_comboBox.Location = new System.Drawing.Point(135, 12);
            this.ID_comboBox.Name = "ID_comboBox";
            this.ID_comboBox.Size = new System.Drawing.Size(256, 21);
            this.ID_comboBox.TabIndex = 24;
            this.ID_comboBox.ValueMember = "Code_category";
            // 
            // partShopDataSet3
            // 
            this.partShopDataSet3.DataSetName = "PartShopDataSet3";
            this.partShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 90);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // categoryPartsName_textBox
            // 
            this.categoryPartsName_textBox.Location = new System.Drawing.Point(135, 39);
            this.categoryPartsName_textBox.Name = "categoryPartsName_textBox";
            this.categoryPartsName_textBox.Size = new System.Drawing.Size(256, 20);
            this.categoryPartsName_textBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название категории";
            // 
            // UpdateCategoryPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryPartsName_textBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ID_comboBox);
            this.Controls.Add(this.label8);
            this.Name = "UpdateCategoryPartsForm";
            this.Text = "UpdateCategoryPartsForm";
            this.Load += new System.EventHandler(this.UpdateCategoryPartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPartsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ID_comboBox;
        private PartShopDataSet3 partShopDataSet3;
        private System.Windows.Forms.BindingSource categoryPartsBindingSource;
        private PartShopDataSet3TableAdapters.CategoryPartsTableAdapter categoryPartsTableAdapter;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox categoryPartsName_textBox;
        private System.Windows.Forms.Label label1;
    }
}