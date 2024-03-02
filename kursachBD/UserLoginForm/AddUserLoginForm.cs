using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachBD.UserLoginForm
{
    public partial class AddUserLoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public AddUserLoginForm()
        {
            InitializeComponent();
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter($"SELECT COUNT(*) FROM UserAuthorization WHERE UserLogin = \'{UserLogin_textBox.Text}\'", con);
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
                        cmd = new SqlCommand("INSERT INTO UserAuthorization(UserLogin, UserPassword) VALUES(@user_login, @user_password)", con);

                        con.Open();

                        cmd.Parameters.AddWithValue("@user_login", UserLogin_textBox.Text);
                        cmd.Parameters.AddWithValue("@user_password", UserPassword_textBox.Text);

                        cmd.ExecuteNonQuery();
                        

                        MessageBox.Show("Запись успешно добавлена");
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
