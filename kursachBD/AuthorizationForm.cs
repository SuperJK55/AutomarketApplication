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
            if (isValidated())
            { //"SELECT COUNT(*) FROM UserAuthorization WHERE UserLogin='" + loginTextBox.Text + "' AND UserPassword='" + passwordTextBox.Text + "'"
                SqlConnection con = new SqlConnection(@"Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter($"EXEC CheckLoginValidate '{loginTextBox.Text}', '{passwordTextBox.Text}'", con);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);
                if ((dt.Rows[0][0].ToString() == "1") && (loginTextBox.Text == "Admin"))
                {
                    new MainForm().ShowDialog();
                    this.Close();
                }
                else if (dt.Rows[0][0].ToString() == "1")
                {
                    new SellerAuthorizatedForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверная пара логин/пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
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
