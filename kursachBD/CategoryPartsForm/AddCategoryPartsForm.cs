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
    public partial class AddCategoryPartsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public AddCategoryPartsForm()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO CategoryParts(Name_category) VALUES(@name_categoryParts)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name_categoryParts", categoryPartsName_textBox.Text);
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
