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

namespace kursachBD
{
    public partial class UpdateForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Parts SET Name_part = @name_part, Type_part = @type_part, Category_part = @category_part, Cost_part = @cost_part, Manufacturer = @manufacturer, Provider_parts = @provider_parts, Description_part = @desc_part " +
                "WHERE Code_part = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name_part", namePart_textBox.Text);
            cmd.Parameters.AddWithValue("@type_part", typePart_textBox.Text);
            cmd.Parameters.AddWithValue("@category_part", categoryPart_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@cost_part", decimal.Parse(costPart_textBox.Text));
            cmd.Parameters.AddWithValue("@manufacturer", manufacturerPart_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@provider_parts", providerParts_comboBox.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@desc_part", descPart_textBox.Text);
            cmd.Parameters.AddWithValue("@id", ID_comboBox.SelectedValue);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно изменена");

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.ProviderParts". При необходимости она может быть перемещена или удалена.
            this.providerPartsTableAdapter.Fill(this.partShopDataSet3.ProviderParts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.partShopDataSet3.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.CategoryParts". При необходимости она может быть перемещена или удалена.
            this.categoryPartsTableAdapter.Fill(this.partShopDataSet3.CategoryParts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet3.Parts);

        }
    }
}
