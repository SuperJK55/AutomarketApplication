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

namespace kursachBD.SellerForm
{
    public partial class UpdateSellerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;

        int id;
        string lastName_seller, firstName_seller, middleName_seller;
        public UpdateSellerForm(int id, string lastName_seller, string firstName_seller, string middleName_seller)
        {
            InitializeComponent();
            this.id = id;
            this.lastName_seller = lastName_seller;
            this.firstName_seller = firstName_seller;
            this.middleName_seller = middleName_seller;
        }

        private void UpdateSellerForm_Load(object sender, EventArgs e)
        {
            IdSeller_textBox.Text = id.ToString();
            lastNameSeller_textBox.Text = lastName_seller;
            firstNameSeller_textBox.Text = firstName_seller;
            middleNameSeller_textBox.Text = middleName_seller;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Sellers SET LastName_seller = @lastName_seller, FirstName_seller = @firstName_seller, MiddleName_seller = @middleName_seller " +
                "WHERE Code_seller = @id", con);
            con.Open();

            cmd.Parameters.AddWithValue("@id", IdSeller_textBox.Text);
            cmd.Parameters.AddWithValue("@lastName_seller", lastNameSeller_textBox.Text);
            cmd.Parameters.AddWithValue("@firstName_seller", firstNameSeller_textBox.Text);
            cmd.Parameters.AddWithValue("@middleName_seller", middleNameSeller_textBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно изменена");
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
