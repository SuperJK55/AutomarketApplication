namespace kursachBD.SellerForm
{
    partial class UpdateSellerForm
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
            this.middleNameSeller_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameSeller_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameSeller_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdSeller_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // middleNameSeller_textBox
            // 
            this.middleNameSeller_textBox.Location = new System.Drawing.Point(156, 96);
            this.middleNameSeller_textBox.Name = "middleNameSeller_textBox";
            this.middleNameSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.middleNameSeller_textBox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Отчество";
            // 
            // firstNameSeller_textBox
            // 
            this.firstNameSeller_textBox.Location = new System.Drawing.Point(156, 67);
            this.firstNameSeller_textBox.Name = "firstNameSeller_textBox";
            this.firstNameSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.firstNameSeller_textBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Имя";
            // 
            // lastNameSeller_textBox
            // 
            this.lastNameSeller_textBox.Location = new System.Drawing.Point(156, 38);
            this.lastNameSeller_textBox.Name = "lastNameSeller_textBox";
            this.lastNameSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.lastNameSeller_textBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Фамилия";
            // 
            // IdSeller_textBox
            // 
            this.IdSeller_textBox.Location = new System.Drawing.Point(156, 8);
            this.IdSeller_textBox.Name = "IdSeller_textBox";
            this.IdSeller_textBox.Size = new System.Drawing.Size(230, 20);
            this.IdSeller_textBox.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID";
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 131);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 43;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 131);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 42;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 168);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.middleNameSeller_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameSeller_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameSeller_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdSeller_textBox);
            this.Controls.Add(this.label8);
            this.Name = "UpdateSellerForm";
            this.Text = "UpdateSellerForm";
            this.Load += new System.EventHandler(this.UpdateSellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox middleNameSeller_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameSeller_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameSeller_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdSeller_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}