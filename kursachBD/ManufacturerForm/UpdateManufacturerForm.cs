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

namespace kursachBD.ManufacturerForm
{
    public partial class UpdateManufacturerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;

        int id;
        string name_manufacturer, address_manufacturer, phoneNumber_manufacturer, email_manufacturer;

        private void UpdateManufacturerForm_Load(object sender, EventArgs e)
        {
            IdManufacturer_textBox.Text = id.ToString();
            nameManufacturer_textBox.Text = name_manufacturer;
            addressManufacturer_textBox.Text = address_manufacturer;
            phoneManufacturer_textBox.Text = phoneNumber_manufacturer;
            emailManufacturer_textBox.Text = email_manufacturer;

        }

        public UpdateManufacturerForm(int id, string name_manufacturer, string address_manufacturer, string phoneNumber_manufacturer, string email_manufacturer)
        {
            InitializeComponent();
            this.id = id;
            this.name_manufacturer = name_manufacturer;
            this.address_manufacturer = address_manufacturer;
            this.phoneNumber_manufacturer = phoneNumber_manufacturer;
            this.email_manufacturer = email_manufacturer;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                cmd = new SqlCommand("UPDATE Manufacturer SET Name_manufacturer = @name_manufacturer, Address_manufacturer = @address_manufacturer, PhoneNumber_manufacturer = @phoneNumber_manufacturer, Email_manufacturer = @email_manufacturer " +
                "WHERE Code_manufacturer = @id", con);
                con.Open();

                cmd.Parameters.AddWithValue("@id", IdManufacturer_textBox.Text);
                cmd.Parameters.AddWithValue("@name_manufacturer", nameManufacturer_textBox.Text);
                cmd.Parameters.AddWithValue("@address_manufacturer", addressManufacturer_textBox.Text);
                cmd.Parameters.AddWithValue("@phoneNumber_manufacturer", phoneManufacturer_textBox.Text);
                cmd.Parameters.AddWithValue("@email_manufacturer", emailManufacturer_textBox.Text);

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

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
