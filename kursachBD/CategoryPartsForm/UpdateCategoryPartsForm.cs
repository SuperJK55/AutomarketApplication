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

namespace kursachBD.CategoryPartsForm
{
    public partial class UpdateCategoryPartsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public UpdateCategoryPartsForm()
        {
            InitializeComponent();
        }

        private void UpdateCategoryPartsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.CategoryParts". При необходимости она может быть перемещена или удалена.
            this.categoryPartsTableAdapter.Fill(this.partShopDataSet3.CategoryParts);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE CategoryParts SET Name_category = @name_categoryParts WHERE Code_category = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name_categoryParts", categoryPartsName_textBox.Text);
            cmd.Parameters.AddWithValue("@id", ID_comboBox.SelectedValue);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Запись успешно изменена");
        }
    }
}
