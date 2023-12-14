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

namespace kursachBD.UserLoginForm
{
    public partial class AddUserLoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
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
            cmd = new SqlCommand("INSERT INTO UserAuthorization(UserLogin, UserPassword) VALUES(@user_login, @user_password)", con);

            con.Open();

            cmd.Parameters.AddWithValue("@user_login", UserLogin_textBox.Text);
            cmd.Parameters.AddWithValue("@user_password", UserPassword_textBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно добавлена");
        }
    }
}
