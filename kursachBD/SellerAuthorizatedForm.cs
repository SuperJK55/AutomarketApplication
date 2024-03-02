using kursachBD.BuyersForm;
using kursachBD.CategoryPartsForm;
using kursachBD.Check;
using kursachBD.ManufacturerForm;
using kursachBD.ProviderForm;
using kursachBD.SalesForm;
using kursachBD.StockForm;
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
    public partial class SellerAuthorizatedForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        PanelControl panelControl;
        List<Panel> panels;
        public SellerAuthorizatedForm()
        {
            InitializeComponent();
            panels = new List<Panel> { PartPanel, CategoryPanel, ManufacturersPanel, ProvidersPanel, StockPanel, SalesPanel, ChecksPanel, BuyersPanel };
            panelControl = new PanelControl(panels);

        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Sellers". При необходимости она может быть перемещена или удалена.
                this.sellersTableAdapter.Fill(this.partShopDataSet4.Sellers);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Buyers". При необходимости она может быть перемещена или удалена.
                this.buyersTableAdapter.Fill(this.partShopDataSet4.Buyers);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.SalesItemList". При необходимости она может быть перемещена или удалена.
                this.salesItemListTableAdapter.Fill(this.partShopDataSet4.SalesItemList);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Sales". При необходимости она может быть перемещена или удалена.
                this.salesTableAdapter.Fill(this.partShopDataSet4.Sales);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Stock". При необходимости она может быть перемещена или удалена.
                this.stockTableAdapter.Fill(this.partShopDataSet4.Stock);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.ProviderParts". При необходимости она может быть перемещена или удалена.
                this.providerPartsTableAdapter.Fill(this.partShopDataSet4.ProviderParts);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Manufacturer". При необходимости она может быть перемещена или удалена.
                this.manufacturerTableAdapter.Fill(this.partShopDataSet4.Manufacturer);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.CategoryParts". При необходимости она может быть перемещена или удалена.
                this.categoryPartsTableAdapter.Fill(this.partShopDataSet4.CategoryParts);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Parts". При необходимости она может быть перемещена или удалена.
                this.partsTableAdapter.Fill(this.partShopDataSet4.Parts);
                con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UpdateTable(string nameTable, DataGridView dataGridView)
        {
            try
            {
                cmd = new SqlCommand($"SELECT * FROM {nameTable}", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к бд. Подробности:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchDataInTable(string nameTable, string columnName, string filterQuery, DataGridView dataGridView)
        {
            try
            {
                cmd = new SqlCommand($"SELECT * FROM {nameTable} WHERE {columnName} LIKE '%{filterQuery}%'", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к бд. Подробности:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.ShowDialog();
        }

        private void endProgramButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res;
                res = MessageBox.Show("Вы действительно хотите завершить работу приложения?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
            UpdateTable("Parts", dataGridView1);
        }
        private void ResetPartButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Parts", dataGridView1);
        }

        private void AddSalesButton_Click(object sender, EventArgs e)
        {
            AddSaleForm addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
            UpdateTable("Sales", dataGridView6);
        }

        private void ResetSalesButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Sales", dataGridView6);
        }

        private void AddChecksButton_Click(object sender, EventArgs e)
        {
            AddChecksForm addChecksForm = new AddChecksForm();
            addChecksForm.ShowDialog();
            
        }

        private void ResetCheckButton_Click(object sender, EventArgs e)
        {
            UpdateTable("SalesItemList", dataGridView7);
        }

        private void AddProvidersButton_Click(object sender, EventArgs e)
        {
            AddProviderForm addProviderForm = new AddProviderForm();
            addProviderForm.ShowDialog();
            UpdateTable("ProviderParts", dataGridView4);
        }

        private void ResetProvidersButton_Click(object sender, EventArgs e)
        {
            UpdateTable("ProviderParts", dataGridView4);
        }

        private void AddBuyersButton_Click(object sender, EventArgs e)
        {
            AddBuyerForm addBuyerForm = new AddBuyerForm();
            addBuyerForm.ShowDialog();
            UpdateTable("Buyers", dataGridView8);
        }

        private void ResetBuyerButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Buyers", dataGridView8);
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryPartsForm addCategoryPartsForm = new AddCategoryPartsForm();
            addCategoryPartsForm.ShowDialog();
            UpdateTable("CategoryParts", dataGridView2);
        }

        private void ResetCategoryButton_Click(object sender, EventArgs e)
        {
            UpdateTable("CategoryParts", dataGridView2);
        }

        private void AddManufacturerButton_Click(object sender, EventArgs e)
        {
            AddManufacturerForm addManufacturerForm = new AddManufacturerForm();
            addManufacturerForm.ShowDialog();
            UpdateTable("Manufacturer", dataGridView3);
        }

        private void ResetManufacturerButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Manufacturer", dataGridView3);
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            AddStockItemForm addStockItemForm = new AddStockItemForm();
            addStockItemForm.ShowDialog();
            UpdateTable("Stock", dataGridView5);
        }

        private void ResetStockButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Stock", dataGridView5);
        }

        private void SearchByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Parts", "Code_part", SearchById_textBox.Text, dataGridView1);
        }
        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Parts", "Name_part", SearchByName_textBox.Text, dataGridView1);
        }
        private void SearchByCategoryButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Parts", "Category_part", SearchByCategory_comboBox.SelectedValue.ToString(), dataGridView1);
        }

        private void SearchCategoryByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("CategoryParts", "Code_category", SearchCategoryById_textBox.Text, dataGridView2);
        }

        private void SearchManufacturerByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Manufacturer", "Code_manufacturer", SearchManufacturerById_textBox.Text, dataGridView3);
        }
        private void SearchManufacturerByNameButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Manufacturer", "Name_manufacturer", SearchManufacturerByName_textBox.Text, dataGridView3);
        }
        private void SearchManufacturerByPhoneButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Manufacturer", "PhoneNumber_manufacturer", SearchManufacturerByPhone_textBox.Text, dataGridView3);
        }

        private void SearchProviderByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("ProviderParts", "Code_provider", SearchProviderById_textBox.Text, dataGridView4);
        }
        private void SearchProviderByNameButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("ProviderParts", "Name_provider", SearchProviderByName_textBox.Text, dataGridView4);
        }
        private void SearchProviderByPhoneButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("ProviderParts", "PhoneNumber_provider", SearchProviderByPhoneNumber_textBox.Text, dataGridView4);
        }

        private void SearchByCodeOnStockButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Stock", "CodePartOn_stock", SearchByCodeOnStock_textBox.Text, dataGridView5);
        }

        private void SearchByPartCodeOnStockButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Stock", "CodePartOn_stock", SearchByPartCodeOnStock_comboBox.SelectedValue.ToString(), dataGridView5);
        }

        private void SearchSaleByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Sales", "Code_sales", SearchSaleById_textBox.Text, dataGridView6);
        }

        private void SearchCheckByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("SalesItemList", "Code_salesItem", SearchCheckById_textBox.Text, dataGridView7);
        }

        private void SearchCheckByOverallCodeButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("SalesItemList", "Code_sales", SearchCheckByOverallCode_textBox.Text, dataGridView7);
        }

        private void SearchBuyerByCodeButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Buyers", "Code_buyer", SearchBuyerByCode_textBox.Text, dataGridView8);
        }
        private void SearchBuyerByNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand($"SELECT * FROM Buyers WHERE LastName_buyer LIKE '%{SearchBuyerByName_textBox.Text}%' AND FirstName_buyer LIKE '%{SearchBuyerBySurname_textBox.Text}%' AND MiddleName_buyer LIKE '%{SearchBuyerByMiddleName_textBox.Text}%'", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView8.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к бд. Подробности:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
