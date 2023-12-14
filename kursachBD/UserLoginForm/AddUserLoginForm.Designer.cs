namespace kursachBD.UserLoginForm
{
    partial class AddUserLoginForm
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
            this.UserLogin_textBox = new System.Windows.Forms.TextBox();
            this.ClosedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UserPassword_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserLogin_textBox
            // 
            this.UserLogin_textBox.Location = new System.Drawing.Point(87, 12);
            this.UserLogin_textBox.Name = "UserLogin_textBox";
            this.UserLogin_textBox.Size = new System.Drawing.Size(304, 20);
            this.UserLogin_textBox.TabIndex = 57;
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 85);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 56;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 85);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 25);
            this.AddButton.TabIndex = 55;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UserPassword_textBox
            // 
            this.UserPassword_textBox.Location = new System.Drawing.Point(87, 42);
            this.UserPassword_textBox.Name = "UserPassword_textBox";
            this.UserPassword_textBox.Size = new System.Drawing.Size(304, 20);
            this.UserPassword_textBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Логин";
            // 
            // AddUserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 121);
            this.Controls.Add(this.UserLogin_textBox);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UserPassword_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "AddUserLoginForm";
            this.Text = "AddUserLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserLogin_textBox;
        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox UserPassword_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}