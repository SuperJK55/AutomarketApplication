using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursachBD
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidated())
                {
                    SqlConnection con = new SqlConnection(@"Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter($"EXEC CheckLoginValidate '{loginTextBox.Text}', '{passwordTextBox.Text}'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        if (loginTextBox.Text == "Admin")
                        {
                            new MainForm().ShowDialog();
                            this.Close();
                        }
                        if (loginTextBox.Text.ToLower().Contains("seller"))
                        {
                            new SellerAuthorizatedForm().ShowDialog();
                            this.Close();
                        }

                    }
                    else if (dt.Rows[0][0].ToString() == "0")
                    {
                        sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserAuthorization", con);
                        dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "0")
                        {
                            if ((loginTextBox.Text == "Admin") && (passwordTextBox.Text == "Admin"))
                            {
                                MessageBox.Show("Начинаем первоначальную настройку.", "Первоначальная настройка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new MainForm().ShowDialog();
                                this.Close();
                            }
                        }
                        else MessageBox.Show("Пользователя не существует/неправильно введен пароль для первоначальной настройки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Неверная пара логин/пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTextBox.Clear();
                        passwordTextBox.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValidated()
        {
            if(loginTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Поле с логином пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginTextBox.Clear();
                passwordTextBox.Clear();
                loginTextBox.Focus();
                return false;
            }
            if(passwordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Поле с паролем пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return false;
            }
            return true;
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            loginTextBox.Clear();
            passwordTextBox.Clear();
            loginTextBox.Focus();
        }
    }
}
