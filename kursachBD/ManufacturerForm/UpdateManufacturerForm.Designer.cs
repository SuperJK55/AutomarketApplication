namespace kursachBD.ManufacturerForm
{
    partial class UpdateManufacturerForm
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
            this.IdManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.nameManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.addressManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.phoneManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.emailManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // IdManufacturer_textBox
            // 
            this.IdManufacturer_textBox.Location = new System.Drawing.Point(155, 19);
            this.IdManufacturer_textBox.Name = "IdManufacturer_textBox";
            this.IdManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.IdManufacturer_textBox.TabIndex = 9;
            // 
            // nameManufacturer_textBox
            // 
            this.nameManufacturer_textBox.Location = new System.Drawing.Point(155, 46);
            this.nameManufacturer_textBox.Name = "nameManufacturer_textBox";
            this.nameManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.nameManufacturer_textBox.TabIndex = 11;
            // 
            // addressManufacturer_textBox
            // 
            this.addressManufacturer_textBox.Location = new System.Drawing.Point(155, 76);
            this.addressManufacturer_textBox.Name = "addressManufacturer_textBox";
            this.addressManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.addressManufacturer_textBox.TabIndex = 15;
            // 
            // phoneManufacturer_textBox
            // 
            this.phoneManufacturer_textBox.Location = new System.Drawing.Point(155, 103);
            this.phoneManufacturer_textBox.Name = "phoneManufacturer_textBox";
            this.phoneManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.phoneManufacturer_textBox.TabIndex = 16;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 186);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 186);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 23;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Электронный адрес производителя";
            // 
            // emailManufacturer_textBox
            // 
            this.emailManufacturer_textBox.Location = new System.Drawing.Point(155, 134);
            this.emailManufacturer_textBox.Multiline = true;
            this.emailManufacturer_textBox.Name = "emailManufacturer_textBox";
            this.emailManufacturer_textBox.Size = new System.Drawing.Size(230, 28);
            this.emailManufacturer_textBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Название производителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Адрес производителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Телефон производителя";
            // 
            // UpdateManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailManufacturer_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.phoneManufacturer_textBox);
            this.Controls.Add(this.addressManufacturer_textBox);
            this.Controls.Add(this.nameManufacturer_textBox);
            this.Controls.Add(this.IdManufacturer_textBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateManufacturerForm";
            this.Text = "UpdateManufacturerForm";
            this.Load += new System.EventHandler(this.UpdateManufacturerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdManufacturer_textBox;
        private System.Windows.Forms.TextBox nameManufacturer_textBox;
        private System.Windows.Forms.TextBox addressManufacturer_textBox;
        private System.Windows.Forms.TextBox phoneManufacturer_textBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailManufacturer_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}