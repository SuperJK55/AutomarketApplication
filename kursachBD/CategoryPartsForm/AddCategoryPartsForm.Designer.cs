namespace kursachBD.CategoryPartsForm
{
    partial class AddCategoryPartsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryPartsName_textBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название категории";
            // 
            // categoryPartsName_textBox
            // 
            this.categoryPartsName_textBox.Location = new System.Drawing.Point(130, 14);
            this.categoryPartsName_textBox.Name = "categoryPartsName_textBox";
            this.categoryPartsName_textBox.Size = new System.Drawing.Size(243, 20);
            this.categoryPartsName_textBox.TabIndex = 1;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(229, 64);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(144, 56);
            this.InsertButton.TabIndex = 15;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // AddCategoryPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 132);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.categoryPartsName_textBox);
            this.Controls.Add(this.label1);
            this.Name = "AddCategoryPartsForm";
            this.Text = "AddCategoryPartsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryPartsName_textBox;
        private System.Windows.Forms.Button InsertButton;
    }
}