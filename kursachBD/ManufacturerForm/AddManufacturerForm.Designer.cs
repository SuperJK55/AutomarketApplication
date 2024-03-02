namespace kursachBD.ManufacturerForm
{
    partial class AddManufacturerForm
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
            this.InsertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailManufacturer_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(247, 167);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(144, 56);
            this.InsertButton.TabIndex = 15;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название производителя";
            // 
            // nameManufacturer_textBox
            // 
            this.nameManufacturer_textBox.Location = new System.Drawing.Point(155, 19);
            this.nameManufacturer_textBox.Name = "nameManufacturer_textBox";
            this.nameManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.nameManufacturer_textBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Адрес производителя";
            // 
            // addressManufacturer_textBox
            // 
            this.addressManufacturer_textBox.Location = new System.Drawing.Point(155, 51);
            this.addressManufacturer_textBox.Name = "addressManufacturer_textBox";
            this.addressManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.addressManufacturer_textBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Телефон производителя";
            // 
            // phoneNumberManufacturer_textBox
            // 
            this.phoneNumberManufacturer_textBox.Location = new System.Drawing.Point(155, 83);
            this.phoneNumberManufacturer_textBox.Name = "phoneNumberManufacturer_textBox";
            this.phoneNumberManufacturer_textBox.Size = new System.Drawing.Size(230, 20);
            this.phoneNumberManufacturer_textBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Электронный адрес производителя";
            // 
            // emailManufacturer_textBox
            // 
            this.emailManufacturer_textBox.Location = new System.Drawing.Point(155, 119);
            this.emailManufacturer_textBox.Multiline = true;
            this.emailManufacturer_textBox.Name = "emailManufacturer_textBox";
            this.emailManufacturer_textBox.Size = new System.Drawing.Size(230, 28);
            this.emailManufacturer_textBox.TabIndex = 23;
            // 
            // AddManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 230);
            this.Controls.Add(this.emailManufacturer_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumberManufacturer_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressManufacturer_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameManufacturer_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertButton);
            this.Name = "AddManufacturerForm";
            this.Text = "AddManufacturerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameManufacturer_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressManufacturer_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNumberManufacturer_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailManufacturer_textBox;
    }
}