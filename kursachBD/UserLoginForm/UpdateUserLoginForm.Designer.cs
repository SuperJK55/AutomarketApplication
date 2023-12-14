namespace kursachBD.UserLoginForm
{
    partial class UpdateUserLoginForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UserPassword_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdUserLogin_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLogin_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClosedButton
            // 
            this.ClosedButton.Location = new System.Drawing.Point(12, 130);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(144, 25);
            this.ClosedButton.TabIndex = 48;
            this.ClosedButton.Text = "Закрыть";
            this.ClosedButton.UseVisualStyleBackColor = true;
            this.ClosedButton.Click += new System.EventHandler(this.ClosedButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(247, 130);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(144, 25);
            this.UpdateButton.TabIndex = 47;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UserPassword_textBox
            // 
            this.UserPassword_textBox.Location = new System.Drawing.Point(81, 75);
            this.UserPassword_textBox.Name = "UserPassword_textBox";
            this.UserPassword_textBox.Size = new System.Drawing.Size(304, 20);
            this.UserPassword_textBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Логин";
            // 
            // IdUserLogin_textBox
            // 
            this.IdUserLogin_textBox.Location = new System.Drawing.Point(81, 16);
            this.IdUserLogin_textBox.Name = "IdUserLogin_textBox";
            this.IdUserLogin_textBox.Size = new System.Drawing.Size(304, 20);
            this.IdUserLogin_textBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // UserLogin_textBox
            // 
            this.UserLogin_textBox.Location = new System.Drawing.Point(81, 45);
            this.UserLogin_textBox.Name = "UserLogin_textBox";
            this.UserLogin_textBox.Size = new System.Drawing.Size(304, 20);
            this.UserLogin_textBox.TabIndex = 49;
            // 
            // UpdateUserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 170);
            this.Controls.Add(this.UserLogin_textBox);
            this.Controls.Add(this.ClosedButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UserPassword_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdUserLogin_textBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUserLoginForm";
            this.Text = "UpdateUserLoginForm";
            this.Load += new System.EventHandler(this.UpdateUserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClosedButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox UserPassword_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdUserLogin_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLogin_textBox;
    }
}