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
    public partial class AddPartForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        MainForm mainForm = new MainForm();  
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.ProviderParts". При необходимости она может быть перемещена или удалена.
            this.providerPartsTableAdapter.Fill(this.partShopDataSet3.ProviderParts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.partShopDataSet3.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet1.CategoryParts". При необходимости она может быть перемещена или удалена.
            this.categoryPartsTableAdapter.Fill(this.partShopDataSet1.CategoryParts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet.Parts);

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part)" +
                "VALUES (@name_part, @type_part, @category_part, @cost_part, @manufacturer, @provider_parts, @desc_part)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name_part", namePart_textBox.Text);
                cmd.Parameters.AddWithValue("@type_part", typePart_textBox.Text);
                cmd.Parameters.AddWithValue("@category_part", categoryPart_comboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@cost_part", decimal.Parse(costPart_textBox.Text));
                cmd.Parameters.AddWithValue("@manufacturer", manufacturerPart_comboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@provider_parts", providerParts_comboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@desc_part", descPart_textBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена");
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
