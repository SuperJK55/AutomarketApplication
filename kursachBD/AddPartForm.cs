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
    public partial class AddPartForm : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
