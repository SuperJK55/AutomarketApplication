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

namespace kursachBD.BuyersForm
{
    public partial class AddBuyerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddBuyerForm()
        {
            InitializeComponent();
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) " +
                "VALUES (@lastName_buyer, @firstName_buyer, @middleName_buyer, @dateBirthday_buyer, @numberPhone_buyer, @email_buyer)", con);
            con.Open();

            cmd.Parameters.AddWithValue("@lastName_buyer", firstNameBuyer_textBox.Text);
            cmd.Parameters.AddWithValue("@firstName_buyer", lastNameBuyer_textBox.Text);
            cmd.Parameters.AddWithValue("@middleName_buyer", middleNameBuyer_textBox.Text);
            cmd.Parameters.AddWithValue("@dateBirthday_buyer", dateBirthday_dateTimePicker.Value);
            cmd.Parameters.AddWithValue("@numberPhone_buyer", numberPhone_textBox.Text);
            cmd.Parameters.AddWithValue("@email_buyer", emailBuyer_textBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно изменена");
        }
    }
}
