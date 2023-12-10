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
    public partial class DeleteCategoryPartsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public DeleteCategoryPartsForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM CategoryParts WHERE Code_category = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", int.Parse(idForDelete_textBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Запись успешно удалена!");
        }
    }
}
