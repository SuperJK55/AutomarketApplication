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

namespace kursachBD.ManufacturerForm
{
    public partial class DeleteManufacturerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        public DeleteManufacturerForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM Manufacturer WHERE Code_manufacturer = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", int.Parse(idForDelete_textBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Запись успешно удалена!");
        }
    }
}
