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

namespace kursachBD.StockForm
{
    public partial class AddStockItemForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public AddStockItemForm()
        {
            InitializeComponent();
        }

        private void AddStockItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet3.Parts);

        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Stock(Code_part, Count_parts) VALUES(@code_part, @count_parts)", con);

                con.Open();

                cmd.Parameters.AddWithValue("@code_part", codePart_comboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@count_parts", countParts_textBox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена");
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
