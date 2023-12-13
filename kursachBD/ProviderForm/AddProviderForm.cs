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

namespace kursachBD.ProviderForm
{
    public partial class AddProviderForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddProviderForm()
        {
            InitializeComponent();
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO ProviderParts(Name_provider, Address_provider, PhoneNumber_provider, Email_provider) " +
               "VALUES (@name_provider, @address_provider, @phoneNumber_provider, @email_provider)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name_provider", nameProvider_textBox.Text);
            cmd.Parameters.AddWithValue("@address_provider", addressProvider_textBox.Text);
            cmd.Parameters.AddWithValue("@phoneNumber_provider", phoneProvider_textBox.Text);
            cmd.Parameters.AddWithValue("@email_provider", emailProvider_textBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно добавлена");
        }
    }
}
