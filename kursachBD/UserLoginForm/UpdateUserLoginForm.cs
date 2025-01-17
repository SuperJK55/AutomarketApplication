﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachBD.UserLoginForm
{
    public partial class UpdateUserLoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        int id;
        string user_login, user_password;
        public UpdateUserLoginForm(int id, string user_login, string user_password)
        {
            InitializeComponent();
            this.id = id;
            this.user_login = user_login;
            this.user_password = user_password;

        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateUserLoginForm_Load(object sender, EventArgs e)
        {
            IdUserLogin_textBox.Text = id.ToString();
            UserLogin_textBox.Text = user_login;
            UserPassword_textBox.Text = user_password;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT COUNT(*) FROM UserAuthorization WHERE UserLogin = \'{UserLogin_textBox.Text}\'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0]) >= 1)
                {
                    MessageBox.Show("Данный пользователь уже существует в базе данных.", "Ошибка добавления нового пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((UserLogin_textBox.Text.ToLower() == "admin") || UserLogin_textBox.Text.ToLower().Contains("admin"))
                {
                    MessageBox.Show("Админ должен быть один.", "SoloAdminException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((UserLogin_textBox.Text.ToLower() == "seller") || UserLogin_textBox.Text.ToLower().Contains("seller"))
                    {
                        cmd = new SqlCommand("UPDATE UserAuthorization SET UserLogin = @user_login, UserPassword = @user_password " +
                           "WHERE UserLogin_code = @id", con);
                        con.Open();

                        cmd.Parameters.AddWithValue("@id", IdUserLogin_textBox.Text);
                        cmd.Parameters.AddWithValue("@user_login", UserLogin_textBox.Text);
                        cmd.Parameters.AddWithValue("@user_password", UserPassword_textBox.Text);

                        cmd.ExecuteNonQuery();
                        

                        MessageBox.Show("Запись успешно изменена");
                    }
                    else MessageBox.Show("Введено неверное имя пользователя для добавления.", "Ошибка добавления нового пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
