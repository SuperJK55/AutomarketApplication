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

namespace kursachBD.SalesForm
{
    public partial class AddSaleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddSaleForm()
        {
            InitializeComponent();
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Sales(Sales_date, Code_buyer, Code_seller) " +
                "VALUES (@sales_date, @code_buyer, @code_seller)", con);
            con.Open();

            cmd.Parameters.AddWithValue("@sales_date", dateSale_dateTimePicker.Value);
            cmd.Parameters.AddWithValue("@code_buyer", codeBuyer_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@code_seller", codeSeller_comboBox.SelectedIndex + 1);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно добавлена");
        }

        private void AddSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.partShopDataSet3.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.partShopDataSet3.Buyers);

        }
    }
}
