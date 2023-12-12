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

namespace kursachBD.Check
{
    public partial class UpdateChecksForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;

        int id, code_sales, code_part, part_amount;

        public UpdateChecksForm(int id, int code_sales, int code_part, int part_amount)
        {
            InitializeComponent();
            this.id = id;
            this.code_sales = code_sales;
            this.code_part = code_part;
            this.part_amount = part_amount;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE SalesItemList SET Code_sales = @code_sales, Code_part = @code_part, Part_amount = @part_amount " +
                "WHERE Code_saleItem = @id", con);
            con.Open();

            cmd.Parameters.AddWithValue("@id", IdSalesItem_textBox.Text);
            cmd.Parameters.AddWithValue("@code_sales", codeSales_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@code_part", codePart_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@part_amount", amountSalelsItem_textBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно изменена");
        }

        

        private void UpdateChecksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet3.Parts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.partShopDataSet3.Sales);
            IdSalesItem_textBox.Text = id.ToString();
            codeSales_comboBox.SelectedValue = code_sales;
            codePart_comboBox.SelectedValue = code_part;
            amountSalelsItem_textBox.Text = part_amount.ToString();
            

        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
