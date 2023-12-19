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
    public partial class UpdateProviderForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;

        int id;
        string name_provider, address_provider, phoneNumber_provider, email_provider;

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateProviderForm_Load(object sender, EventArgs e)
        {
            IdProvider_textBox.Text = id.ToString();
            nameProvider_textBox.Text = name_provider;
            addressProvider_textBox.Text = address_provider;
            phoneProvider_textBox.Text = phoneNumber_provider;
            emailProvider_textBox.Text = email_provider;
        }

        public UpdateProviderForm(int id, string name_provider, string address_provider, string phoneNumber_provider, string email_provider)
        {
            InitializeComponent();
            this.id = id;
            this.name_provider = name_provider;
            this.address_provider = address_provider;
            this.phoneNumber_provider = phoneNumber_provider;
            this.email_provider = email_provider;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE ProviderParts SET Name_provider = @name_provider, Address_provider = @address_provider, PhoneNumber_provider = @phoneNumber_provider, Email_provider = @email_provider " +
               "WHERE Code_provider = @id", con);
                con.Open();

                cmd.Parameters.AddWithValue("@id", IdProvider_textBox.Text);
                cmd.Parameters.AddWithValue("@name_provider", nameProvider_textBox.Text);
                cmd.Parameters.AddWithValue("@address_provider", addressProvider_textBox.Text);
                cmd.Parameters.AddWithValue("@phoneNumber_provider", phoneProvider_textBox.Text);
                cmd.Parameters.AddWithValue("@email_provider", emailProvider_textBox.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись успешно изменена");
            }
            catch (Exception ex)
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
