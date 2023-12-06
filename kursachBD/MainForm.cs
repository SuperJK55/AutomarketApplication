using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PartsButton_Click(object sender, EventArgs e)
        {

        }

        private void CategoryPartsButton_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturerButton_Click(object sender, EventArgs e)
        {

        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {

        }

        private void StockButton_Click(object sender, EventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {

        }

        private void ChecksButton_Click(object sender, EventArgs e)
        {

        }

        private void BuyersButton_Click(object sender, EventArgs e)
        {

        }

        private void SellersButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.partShopDataSet.Parts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            partsBindingSource.Remove(bb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.partsTableAdapter.Update(this.partShopDataSet.Parts);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.ShowDialog();
        }
    }
}
