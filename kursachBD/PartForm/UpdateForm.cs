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
        MainForm mainForm = new MainForm();

        int id, category_part, manufacturer, provider;
        double cost_part;
        string name_part, type_part, description;

        private void ClosedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataGridView dataGridView;
        public UpdateForm(int id, string name_part, string type_part, int category_part, double cost_part, int manufacturer, int provider, string description, DataGridView dataGridView)
        {
            InitializeComponent();
            this.id = id;
            this.name_part = name_part;
            this.type_part = type_part;
            this.category_part = category_part;
            this.cost_part = cost_part;
            this.manufacturer = manufacturer;
            this.provider = provider;
            this.description = description;
            this.dataGridView = dataGridView;
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

            ID_comboBox.SelectedValue = id.ToString();
            namePart_textBox.Text = name_part;
            typePart_textBox.Text = type_part;
            categoryPart_comboBox.SelectedValue = category_part.ToString();
            costPart_textBox.Text = cost_part.ToString();
            manufacturerPart_comboBox.SelectedValue = manufacturer.ToString();
            providerParts_comboBox.SelectedValue = provider.ToString();
            descPart_textBox.Text = description;
        }
    }
}
