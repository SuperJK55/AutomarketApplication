﻿namespace kursachBD
{
    partial class DeletedForm
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
            this.idForDelete = new System.Windows.Forms.Label();
            this.idForDelete_textBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idForDelete
            // 
            this.idForDelete.AutoSize = true;
            this.idForDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idForDelete.Location = new System.Drawing.Point(26, 51);
            this.idForDelete.Name = "idForDelete";
            this.idForDelete.Size = new System.Drawing.Size(354, 15);
            this.idForDelete.TabIndex = 0;
            this.idForDelete.Text = "Введите уникальный номер строки, которую нужно удалить";
            // 
            // idForDelete_textBox
            // 
            this.idForDelete_textBox.Location = new System.Drawing.Point(29, 81);
            this.idForDelete_textBox.Name = "idForDelete_textBox";
            this.idForDelete_textBox.Size = new System.Drawing.Size(351, 20);
            this.idForDelete_textBox.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(29, 132);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(351, 75);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "УДАЛИИИИТЬ!";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeletedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 278);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.idForDelete_textBox);
            this.Controls.Add(this.idForDelete);
            this.Name = "DeletedForm";
            this.Text = "PartForm - Удаление записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idForDelete;
        private System.Windows.Forms.TextBox idForDelete_textBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}