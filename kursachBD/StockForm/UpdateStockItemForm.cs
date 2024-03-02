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
    public partial class UpdateStockItemForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        int id, code_part, count_parts;

        public UpdateStockItemForm(int id, int code_part, int count_parts)
        {
            InitializeComponent();
            this.id = id;
            this.code_part = code_part;
            this.count_parts = count_parts;
        }

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateStockItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet3.Parts);
            IdStockItem_textBox.Text = id.ToString();
            codePart_comboBox.SelectedValue = code_part.ToString();
            countParts_textBox.Text = count_parts.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Stock SET Code_part = @code_part, Count_parts = @count_parts " +
                "WHERE CodePartOn_stock = @id", con);
                con.Open();

                cmd.Parameters.AddWithValue("@id", IdStockItem_textBox.Text);
                cmd.Parameters.AddWithValue("@code_part", codePart_comboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@count_parts", countParts_textBox.Text);

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
