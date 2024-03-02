namespace kursachBD.ProviderForm
{
    partial class UpdateProviderForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.IdProvider_textBox = new System.Windows.Forms.TextBox();
            this.nameProvider_textBox = new System.Windows.Forms.TextBox();
            this.addressProvider_textBox = new System.Windows.Forms.TextBox();
            this.phoneProvider_textBox = new System.Windows.Forms.TextBox();
            this.emailProvider_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Название производителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Адрес производителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Телефон производителя";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Электронный адрес производителя";
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 186);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 31;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 186);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 32;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // IdProvider_textBox
            // 
            this.IdProvider_textBox.Location = new System.Drawing.Point(155, 19);
            this.IdProvider_textBox.Name = "IdProvider_textBox";
            this.IdProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.IdProvider_textBox.TabIndex = 33;
            // 
            // nameProvider_textBox
            // 
            this.nameProvider_textBox.Location = new System.Drawing.Point(155, 50);
            this.nameProvider_textBox.Name = "nameProvider_textBox";
            this.nameProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.nameProvider_textBox.TabIndex = 34;
            // 
            // addressProvider_textBox
            // 
            this.addressProvider_textBox.Location = new System.Drawing.Point(155, 80);
            this.addressProvider_textBox.Name = "addressProvider_textBox";
            this.addressProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.addressProvider_textBox.TabIndex = 35;
            // 
            // phoneProvider_textBox
            // 
            this.phoneProvider_textBox.Location = new System.Drawing.Point(155, 110);
            this.phoneProvider_textBox.Name = "phoneProvider_textBox";
            this.phoneProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.phoneProvider_textBox.TabIndex = 36;
            // 
            // emailProvider_textBox
            // 
            this.emailProvider_textBox.Location = new System.Drawing.Point(155, 134);
            this.emailProvider_textBox.Multiline = true;
            this.emailProvider_textBox.Name = "emailProvider_textBox";
            this.emailProvider_textBox.Size = new System.Drawing.Size(230, 28);
            this.emailProvider_textBox.TabIndex = 37;
            // 
            // UpdateProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 223);
            this.Controls.Add(this.emailProvider_textBox);
            this.Controls.Add(this.phoneProvider_textBox);
            this.Controls.Add(this.addressProvider_textBox);
            this.Controls.Add(this.nameProvider_textBox);
            this.Controls.Add(this.IdProvider_textBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProviderForm";
            this.Text = "UpdateProviderForm";
            this.Load += new System.EventHandler(this.UpdateProviderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox IdProvider_textBox;
        private System.Windows.Forms.TextBox nameProvider_textBox;
        private System.Windows.Forms.TextBox addressProvider_textBox;
        private System.Windows.Forms.TextBox phoneProvider_textBox;
        private System.Windows.Forms.TextBox emailProvider_textBox;
    }
}