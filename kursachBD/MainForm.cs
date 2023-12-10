using kursachBD.CategoryPartsForm;
using kursachBD.ManufacturerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace kursachBD
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        PanelControl panelControl;
        List<Panel> panels;
        public MainForm()
        {
            InitializeComponent();
            panels = new List<Panel> { PartPanel, CategoryPanel, ManufacturersPanel, ProvidersPanel, StockPanel, SalesPanel, ChecksPanel, BuyersPanel, SellersPanel };
            panelControl = new PanelControl(panels);

        }
        
        public void UpdateTable(string nameTable, DataGridView dataGridView)
        {
            
            con.Open();
            cmd = new SqlCommand($"SELECT * FROM {nameTable}", con);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void PartsButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            PartPanel.Visible = true;
        }

        private void CategoryPartsButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            CategoryPanel.Visible = true;
        }

        private void ManufacturerButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            ManufacturersPanel.Visible = true;
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            ProvidersPanel.Visible = true;
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            StockPanel.Visible = true;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            SalesPanel.Visible = true;
        }

        private void ChecksButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            ChecksPanel.Visible = true;
        }

        private void BuyersButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            BuyersPanel.Visible = true;
        }

        private void SellersButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            SellersPanel.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.partShopDataSet3.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.partShopDataSet3.Buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.SalesItemList". При необходимости она может быть перемещена или удалена.
            this.salesItemListTableAdapter.Fill(this.partShopDataSet3.SalesItemList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.partShopDataSet3.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.partShopDataSet3.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.ProviderParts". При необходимости она может быть перемещена или удалена.
            this.providerPartsTableAdapter.Fill(this.partShopDataSet3.ProviderParts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.partShopDataSet3.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.CategoryParts". При необходимости она может быть перемещена или удалена.
            this.categoryPartsTableAdapter.Fill(this.partShopDataSet3.CategoryParts);
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
            DeletedForm deletedForm = new DeletedForm();
            deletedForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

       

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.ShowDialog();
        }

        

        private void endProgramButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы действительно хотите завершить работу приложения?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else this.Show();
            
        }
        private void updatePartsTableButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Parts", dataGridView1);
        }
        private void UpdateTableCategoryButton_Click(object sender, EventArgs e)
        {
            UpdateTable("CategoryParts", dataGridView2);
        }
        private void UpdateTableManufacturerButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Manufacturer", dataGridView3);
        }
        private void UpdateTableSellersButton_Click(object sender, EventArgs e)
        {
            
        }
        

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryPartsForm addCategoryPartsForm = new AddCategoryPartsForm();
            addCategoryPartsForm.ShowDialog();
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            DeleteCategoryPartsForm deleteCategoryPartsForm = new DeleteCategoryPartsForm();
            deleteCategoryPartsForm.ShowDialog();
        }

        private void UpdateCategoryButton_Click(object sender, EventArgs e)
        {
            UpdateCategoryPartsForm updateCategoryPartsForm = new UpdateCategoryPartsForm();
            updateCategoryPartsForm.ShowDialog();
        }

        private void AddSellersButton_Click(object sender, EventArgs e)
        {

        }

        private void AddManufacturerButton_Click(object sender, EventArgs e)
        {
            AddManufacturerForm addManufacturerForm = new AddManufacturerForm();
            addManufacturerForm.ShowDialog();
        }

        private void DeleteManufacturerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
