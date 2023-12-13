namespace kursachBD.ProviderForm
{
    partial class AddProviderForm
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
            this.emailProvider_textBox = new System.Windows.Forms.TextBox();
            this.phoneProvider_textBox = new System.Windows.Forms.TextBox();
            this.addressProvider_textBox = new System.Windows.Forms.TextBox();
            this.nameProvider_textBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailProvider_textBox
            // 
            this.emailProvider_textBox.Location = new System.Drawing.Point(156, 96);
            this.emailProvider_textBox.Multiline = true;
            this.emailProvider_textBox.Name = "emailProvider_textBox";
            this.emailProvider_textBox.Size = new System.Drawing.Size(230, 28);
            this.emailProvider_textBox.TabIndex = 49;
            // 
            // phoneProvider_textBox
            // 
            this.phoneProvider_textBox.Location = new System.Drawing.Point(156, 72);
            this.phoneProvider_textBox.Name = "phoneProvider_textBox";
            this.phoneProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.phoneProvider_textBox.TabIndex = 48;
            // 
            // addressProvider_textBox
            // 
            this.addressProvider_textBox.Location = new System.Drawing.Point(156, 42);
            this.addressProvider_textBox.Name = "addressProvider_textBox";
            this.addressProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.addressProvider_textBox.TabIndex = 47;
            // 
            // nameProvider_textBox
            // 
            this.nameProvider_textBox.Location = new System.Drawing.Point(156, 12);
            this.nameProvider_textBox.Name = "nameProvider_textBox";
            this.nameProvider_textBox.Size = new System.Drawing.Size(230, 20);
            this.nameProvider_textBox.TabIndex = 46;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 149);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 25);
            this.AddButton.TabIndex = 44;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 149);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 43;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Электронный адрес производителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Телефон производителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Адрес производителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Название производителя";
            // 
            // AddProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 183);
            this.Controls.Add(this.emailProvider_textBox);
            this.Controls.Add(this.phoneProvider_textBox);
            this.Controls.Add(this.addressProvider_textBox);
            this.Controls.Add(this.nameProvider_textBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "AddProviderForm";
            this.Text = "AddProviderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailProvider_textBox;
        private System.Windows.Forms.TextBox phoneProvider_textBox;
        private System.Windows.Forms.TextBox addressProvider_textBox;
        private System.Windows.Forms.TextBox nameProvider_textBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}