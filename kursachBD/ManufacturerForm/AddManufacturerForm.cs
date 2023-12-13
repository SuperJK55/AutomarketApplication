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
    public partial class AddManufacturerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddManufacturerForm()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Manufacturer(Name_manufacturer, Address_manufacturer, PhoneNumber_manufacturer, Email_manufacturer) " +
                "VALUES (@name_manufacturer, @address_manufacturer, @phone_manufacturer, @email_manufacturer)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name_manufacturer", nameManufacturer_textBox.Text);
            cmd.Parameters.AddWithValue("@address_manufacturer", addressManufacturer_textBox.Text);
            cmd.Parameters.AddWithValue("@phone_manufacturer", phoneNumberManufacturer_textBox.Text);
            cmd.Parameters.AddWithValue("@email_manufacturer", emailManufacturer_textBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно добавлена");
        }
    }
}
