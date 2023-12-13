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
    public partial class UpdateBuyerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;

        int id;
        string lastName_buyer, firstName_buyer, middleName_buyer, numberPhone_buyer, email_buyer;
        DateTime dateBirthday;

        private void UpdateBuyerForm_Load(object sender, EventArgs e)
        {
            IdBuyer_textBox.Text = id.ToString();
            firstNameBuyer_textBox.Text = firstName_buyer;
            lastNameBuyer_textBox.Text = lastName_buyer;
            middleNameBuyer_textBox.Text = middleName_buyer;
            dateBirthday_dateTimePicker.Value = dateBirthday;
            numberPhone_textBox.Text = numberPhone_buyer;
            emailBuyer_textBox.Text = email_buyer;

        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public UpdateBuyerForm(int id, string lastName_buyer, string firstName_buyer, string middleName_buyer, string numberPhone_buyer, string email_buyer, DateTime dateBirthday)
        {
            InitializeComponent();
            this.id = id;
            this.lastName_buyer = lastName_buyer;
            this.firstName_buyer = firstName_buyer;
            this.middleName_buyer = middleName_buyer;
            this.numberPhone_buyer = numberPhone_buyer;
            this.email_buyer = email_buyer;
            this.dateBirthday = dateBirthday;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Buyers SET LastName_buyer = @lastName_buyer, FirstName_buyer = @firstName_buyer, MiddleName_buyer = @middleName_buyer, DateBirthday_buyer = @dateBirthday_buyer, NumberPhone_buyer = @numberPhone_buyer, Email_buyer = @email_buyer " +
                "WHERE Code_buyer = @id", con);
            con.Open();

            cmd.Parameters.AddWithValue("@id", IdBuyer_textBox.Text);
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
