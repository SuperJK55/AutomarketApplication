namespace kursachBD.SellerForm
{
    partial class AddSellerForm
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
            this.ClosedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.middleNameSeller_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameSeller_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameSeller_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 118);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 51;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 118);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 25);
            this.AddButton.TabIndex = 50;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // middleNameSeller_textBox
            // 
            this.middleNameSeller_textBox.Location = new System.Drawing.Point(156, 83);
            this.middleNameSeller_textBox.Name = "middleNameSeller_textBox";
            this.middleNameSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.middleNameSeller_textBox.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Отчество";
            // 
            // lastNameSeller_textBox
            // 
            this.lastNameSeller_textBox.Location = new System.Drawing.Point(156, 54);
            this.lastNameSeller_textBox.Name = "lastNameSeller_textBox";
            this.lastNameSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.lastNameSeller_textBox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Имя";
            // 
            // firstNameSeller_textBox
            // 
            this.firstNameSeller_textBox.Location = new System.Drawing.Point(156, 25);
            this.firstNameSeller_textBox.Name = "firstNameSeller_textBox";
            this.firstNameSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.firstNameSeller_textBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Фамилия";
            // 
            // AddSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 168);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.middleNameSeller_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameSeller_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameSeller_textBox);
            this.Controls.Add(this.label6);
            this.Name = "AddSellerForm";
            this.Text = "AddSellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox middleNameSeller_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameSeller_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameSeller_textBox;
        private System.Windows.Forms.Label label6;
    }
}