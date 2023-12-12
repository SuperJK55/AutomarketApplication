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
    public partial class UpdateSaleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;

        int id, code_buyer, code_seller;
        
        DateTime dateTime;
        public UpdateSaleForm(int id, int code_buyer, int code_seller, DateTime dateTime)
        {
            InitializeComponent();
            this.id = id;
            this.code_buyer = code_buyer;
            this.code_seller = code_seller;
            this.dateTime = dateTime;
        }
        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Sales SET Sales_date = @sales_date, Code_buyer = @code_buyer, Code_seller = @code_seller " +
                "WHERE Code_sales = @id", con);
            con.Open();

            cmd.Parameters.AddWithValue("@id", IdSale_textBox.Text);
            cmd.Parameters.AddWithValue("@sales_date", dateSale_dateTimePicker.Value);
            cmd.Parameters.AddWithValue("@code_buyer", codeBuyer_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@code_seller", codeSeller_comboBox.SelectedIndex + 1);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно изменена");
        }

        

        private void UpdateSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.partShopDataSet3.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.partShopDataSet3.Buyers);


        }
    }
}
