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
    public partial class AddSellerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddSellerForm()
        {
            InitializeComponent();
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Sellers(LastName_seller, FirstName_seller, MiddleName_seller)" +
                "VALUES (@lastName_seller, @firstName_seller, @middleName_seller)", con);
                con.Open();

                cmd.Parameters.AddWithValue("@lastName_seller", firstNameSeller_textBox.Text);
                cmd.Parameters.AddWithValue("@firstName_seller", lastNameSeller_textBox.Text);
                cmd.Parameters.AddWithValue("@middleName_seller", middleNameSeller_textBox.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись успешно изменена");
            }
            catch(Exception ex)
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
