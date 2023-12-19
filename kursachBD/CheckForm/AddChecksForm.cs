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
    public partial class AddChecksForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddChecksForm()
        {
            InitializeComponent();
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddChecksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet3.Parts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.partShopDataSet3.Sales);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO SalesItemList(Code_sales, Code_part, Part_amount) " +
                "VALUES (@code_sales, @code_part, @part_amount)", con);
                con.Open();

                cmd.Parameters.AddWithValue("@code_sales", codeSales_comboBox.SelectedIndex + 2);
                cmd.Parameters.AddWithValue("@code_part", codePart_comboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@part_amount", Convert.ToInt32(amountSalelsItem_textBox.Text));

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
