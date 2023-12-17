using kursachBD.BuyersForm;
using kursachBD.CategoryPartsForm;
using kursachBD.Check;
using kursachBD.ManufacturerForm;
using kursachBD.ProviderForm;
using kursachBD.SalesForm;
using kursachBD.SellerForm;
using kursachBD.StockForm;
using kursachBD.UserLoginForm;
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
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using System.Xml;

namespace kursachBD
{
    public partial class MainForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        PanelControl panelControl;
        List<Panel> panels;
        string connectionString;
        public MainForm()
        {
            InitializeComponent();
            panels = new List<Panel> { PartPanel, CategoryPanel, ManufacturersPanel, ProvidersPanel, StockPanel, SalesPanel, ChecksPanel, BuyersPanel, SellersPanel, SettingsPanel, UserLoginPanel };
            panelControl = new PanelControl(panels);
            
            //= new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;")
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
        private void DeleteButtonTable(DataGridViewCellEventArgs e, string table_name, string id_column_cell, string id_column_name, DataGridView dataGridView)
        {
                int id;
                id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[id_column_cell].Value);
                con.Open();
                try
                {
                    string query = $"DELETE FROM {table_name} WHERE {id_column_name} = @id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Данные удалены успешно");
                        UpdateTable(table_name, dataGridView);
                    }
                    else
                    {
                        MessageBox.Show("Данные не удалены");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
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

        private void SellersButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            SellersPanel.Visible = true;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            SettingsPanel.Visible = true;
        }
        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            panelControl.HidePanels();
            UserLoginPanel.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter2.Fill(this.partShopDataSet4.Parts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.CategoryParts". При необходимости она может быть перемещена или удалена.
            this.categoryPartsTableAdapter1.Fill(this.partShopDataSet4.CategoryParts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet4.UserAuthorization". При необходимости она может быть перемещена или удалена.
            this.userAuthorizationTableAdapter.Fill(this.partShopDataSet4.UserAuthorization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partShopDataSet3.Parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter1.Fill(this.partShopDataSet3.Parts);
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
            sqlConnection_textBox.Text = "Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;";
            con = new SqlConnection("Data Source=SUPERJK;Initial Catalog=PartShop;Integrated Security=True;");
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
                System.Windows.Forms.Application.Exit();
            }
            else this.Show();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "Parts", "codepartDataGridViewTextBoxColumn", "Code_part", dataGridView1);
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id, category_part, manufacturer, provider;
                double cost_part;
                string name_part, type_part, description;

                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["codepartDataGridViewTextBoxColumn"].Value);
                name_part = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["namepartDataGridViewTextBoxColumn"].Value);
                type_part = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["typepartDataGridViewTextBoxColumn"].Value);
                category_part = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["categorypartDataGridViewTextBoxColumn"].Value);
                cost_part = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["costpartDataGridViewTextBoxColumn"].Value);
                manufacturer = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["manufacturerDataGridViewTextBoxColumn"].Value);
                provider = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["providerpartsDataGridViewTextBoxColumn"].Value);
                description = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["descriptionpartDataGridViewTextBoxColumn"].Value);

                UpdateForm updateForm = new UpdateForm(id, name_part, type_part, category_part, cost_part, manufacturer, provider, description);
                updateForm.ShowDialog();
                UpdateTable("Parts", dataGridView1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
            UpdateTable("Parts", dataGridView1);
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
        private void ResetPartButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Parts", dataGridView1);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "CategoryParts", "codecategoryDataGridViewTextBoxColumn", "Code_category", dataGridView2);
            }
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id;
                string name_category;

                id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["codecategoryDataGridViewTextBoxColumn"].Value);
                name_category = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["namecategoryDataGridViewTextBoxColumn"].Value);

                UpdateCategoryPartsForm updateForm = new UpdateCategoryPartsForm(id, name_category);
                updateForm.ShowDialog();
                UpdateTable("CategoryParts", dataGridView2);
            }
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryPartsForm addCategoryPartsForm = new AddCategoryPartsForm();
            addCategoryPartsForm.ShowDialog();
            UpdateTable("CategoryParts", dataGridView2);
        }
        private void SearchCategoryByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("CategoryParts", "Code_category", SearchCategoryById_textBox.Text, dataGridView2);
        }
        private void ResetCategoryButton_Click(object sender, EventArgs e)
        {
            UpdateTable("CategoryParts", dataGridView2);
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "Manufacturer", "codemanufacturerDataGridViewTextBoxColumn", "Code_manufacturer", dataGridView3);
            }
            if (dataGridView3.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id;
                string name_manufacturer, address_manufacturer, phoneNumber_manufacturer, email_manufacturer;

                id = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["codemanufacturerDataGridViewTextBoxColumn"].Value);
                name_manufacturer = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells["namemanufacturerDataGridViewTextBoxColumn"].Value);
                address_manufacturer = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells["addressmanufacturerDataGridViewTextBoxColumn"].Value);
                phoneNumber_manufacturer = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells["phoneNumbermanufacturerDataGridViewTextBoxColumn"].Value);
                email_manufacturer = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells["emailmanufacturerDataGridViewTextBoxColumn"].Value);

                UpdateManufacturerForm updateForm = new UpdateManufacturerForm(id, name_manufacturer, address_manufacturer, phoneNumber_manufacturer, email_manufacturer);
                updateForm.ShowDialog();
                UpdateTable("Manufacturer", dataGridView3);
            }
        }
        private void AddManufacturerButton_Click(object sender, EventArgs e)
        {
            AddManufacturerForm addManufacturerForm = new AddManufacturerForm();
            addManufacturerForm.ShowDialog();
            UpdateTable("Manufacturer", dataGridView3);
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
        private void ResetManufacturerButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Manufacturer", dataGridView3);
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "ProviderParts", "codeproviderDataGridViewTextBoxColumn", "Code_provider", dataGridView4);
            }
            if (dataGridView4.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id;
                string name_provider, address_provider, phoneNumber_provider, email_provider;

                id = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["codeproviderDataGridViewTextBoxColumn"].Value);
                name_provider = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["nameproviderDataGridViewTextBoxColumn"].Value);
                address_provider = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["addressproviderDataGridViewTextBoxColumn"].Value);
                phoneNumber_provider = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["phoneNumberproviderDataGridViewTextBoxColumn"].Value);
                email_provider = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["emailproviderDataGridViewTextBoxColumn"].Value);

                UpdateProviderForm updateForm = new UpdateProviderForm(id, name_provider, address_provider, phoneNumber_provider, email_provider);
                updateForm.ShowDialog();
                UpdateTable("ProviderParts", dataGridView4);
            }
        }
        private void AddProvidersButton_Click(object sender, EventArgs e)
        {
            AddProviderForm addProviderForm = new AddProviderForm();
            addProviderForm.ShowDialog();
            UpdateTable("ProviderParts", dataGridView4);
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
        private void ResetProvidersButton_Click(object sender, EventArgs e)
        {
            UpdateTable("ProviderParts", dataGridView4);
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "Stock", "codePartOnstockDataGridViewTextBoxColumn", "CodePartOn_stock", dataGridView5);
            }
            if (dataGridView5.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id, code_part, count_parts;

                id = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["codePartOnstockDataGridViewTextBoxColumn"].Value);
                code_part = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["codepartDataGridViewTextBoxColumn1"].Value);
                count_parts = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["countpartsDataGridViewTextBoxColumn"].Value);
                
                UpdateStockItemForm updateForm = new UpdateStockItemForm(id, code_part, count_parts);
                updateForm.ShowDialog();
                UpdateTable("Stock", dataGridView5);
            }
        }
        private void AddStockButton_Click(object sender, EventArgs e)
        {
            AddStockItemForm addStockItemForm = new AddStockItemForm();
            addStockItemForm.ShowDialog();
            UpdateTable("Stock", dataGridView5);
        }
        private void SearchByCodeOnStockButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Stock", "CodePartOn_stock", SearchByCodeOnStock_textBox.Text, dataGridView5);
        }

        private void SearchByPartCodeOnStockButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Stock", "CodePartOn_stock", SearchByPartCodeOnStock_comboBox.SelectedValue.ToString(), dataGridView5);
        }
        private void ResetStockButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Stock", dataGridView5);
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "Sales", "codesalesDataGridViewTextBoxColumn", "Code_sales", dataGridView6);
            }
            if (dataGridView6.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id, code_buyer, count_seller;
                DateTime dateTime_sale;

                id = Convert.ToInt32(dataGridView6.Rows[e.RowIndex].Cells["codePartOnstockDataGridViewTextBoxColumn"].Value);
                dateTime_sale = Convert.ToDateTime(dataGridView6.Rows[e.RowIndex].Cells["salesdateDataGridViewTextBoxColumn"].Value);
                code_buyer = Convert.ToInt32(dataGridView6.Rows[e.RowIndex].Cells["codebuyerDataGridViewTextBoxColumn"].Value);
                count_seller = Convert.ToInt32(dataGridView6.Rows[e.RowIndex].Cells["codesellerDataGridViewTextBoxColumn"].Value);
                

                UpdateSaleForm updateForm = new UpdateSaleForm(id, code_buyer, count_seller, dateTime_sale);
                updateForm.ShowDialog();
                UpdateTable("Sales", dataGridView6);
            }
        }
        private void AddSalesButton_Click(object sender, EventArgs e)
        {
            AddSaleForm addSaleForm = new AddSaleForm();
            addSaleForm.ShowDialog();
            UpdateTable("Sales", dataGridView6);
        }
        private void SearchSaleByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Sales", "Code_sales", SearchSaleById_textBox.Text, dataGridView6);
        }
        private void ResetSalesButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Sales", dataGridView6);
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView7.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "SalesItemList", "codesalesItemDataGridViewTextBoxColumn", "Code_salesItem", dataGridView7);
            }
            if (dataGridView7.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id, code_sales, code_part, part_amount;

                id = Convert.ToInt32(dataGridView7.Rows[e.RowIndex].Cells["codesalesItemDataGridViewTextBoxColumn"].Value);
                code_sales = Convert.ToInt32(dataGridView7.Rows[e.RowIndex].Cells["codesalesDataGridViewTextBoxColumn1"].Value);
                code_part = Convert.ToInt32(dataGridView7.Rows[e.RowIndex].Cells["codepartDataGridViewTextBoxColumn2"].Value);
                part_amount = Convert.ToInt32(dataGridView7.Rows[e.RowIndex].Cells["partamountDataGridViewTextBoxColumn"].Value);


                UpdateChecksForm updateForm = new UpdateChecksForm(id, code_sales, code_part, part_amount);
                updateForm.ShowDialog();
                UpdateTable("SalesItemList", dataGridView7);
            }
        }
        private void ReportButton_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("SELECT * FROM SalesItemList", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView7.DataSource = dt;
            Microsoft.Office.Interop.Word._Application wordApp = new Microsoft.Office.Interop.Word.Application();

            for (int k = 0; k < dt.Rows.Count; k++)
            {
                Document doc = wordApp.Documents.Add();
                Table table = doc.Tables.Add(Range: doc.Range(), NumRows: 2, NumColumns: dt.Columns.Count, DefaultTableBehavior: WdDefaultTableBehavior.wdWord9TableBehavior, AutoFitBehavior: WdAutoFitBehavior.wdAutoFitContent);

                // Add headers to the table
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    table.Cell(1, i + 1).Range.Text = dt.Columns[i].ColumnName;
                }

                // Add data to the table
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    table.Cell(2, j + 1).Range.Text = dt.Rows[k][j].ToString();
                }

                object fileName = "K:\\Report" + (k + 1) + ".docx";
                doc.SaveAs2(ref fileName);
                doc.Close();
            }

            wordApp.Quit();

        }
        private void AddChecksButton_Click(object sender, EventArgs e)
        {
            AddChecksForm addChecksForm = new AddChecksForm();
            addChecksForm.ShowDialog();
            UpdateTable("SalesItemList", dataGridView7);
        }
        private void SearchCheckByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("SalesItemList", "Code_salesItem", SearchCheckById_textBox.Text, dataGridView7);
        }

        private void SearchCheckByOverallCodeButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("SalesItemList", "Code_sales", SearchCheckByOverallCode_textBox.Text, dataGridView7);
        }
        private void ResetCheckButton_Click(object sender, EventArgs e)
        {
            UpdateTable("SalesItemList", dataGridView7);
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView8.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "Buyers", "codebuyerDataGridViewTextBoxColumn1", "Code_buyer", dataGridView8);
            }
            if (dataGridView8.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id;
                string lastName_buyer, firstName_buyer, middleName_buyer, numberPhone_buyer, email_buyer;
                DateTime dateBirthday;

                id = Convert.ToInt32(dataGridView8.Rows[e.RowIndex].Cells["codebuyerDataGridViewTextBoxColumn1"].Value);
                lastName_buyer = Convert.ToString(dataGridView8.Rows[e.RowIndex].Cells["lastNamebuyerDataGridViewTextBoxColumn"].Value);
                firstName_buyer = Convert.ToString(dataGridView8.Rows[e.RowIndex].Cells["firstNamebuyerDataGridViewTextBoxColumn"].Value);
                middleName_buyer = Convert.ToString(dataGridView8.Rows[e.RowIndex].Cells["middleNamebuyerDataGridViewTextBoxColumn"].Value);
                dateBirthday = Convert.ToDateTime(dataGridView8.Rows[e.RowIndex].Cells["dateBirthdaybuyerDataGridViewTextBoxColumn"].Value);
                numberPhone_buyer = Convert.ToString(dataGridView8.Rows[e.RowIndex].Cells["numberPhonebuyerDataGridViewTextBoxColumn"].Value);
                email_buyer = Convert.ToString(dataGridView8.Rows[e.RowIndex].Cells["emailbuyerDataGridViewTextBoxColumn"].Value);

                UpdateBuyerForm updateForm = new UpdateBuyerForm(id, lastName_buyer, firstName_buyer, middleName_buyer, numberPhone_buyer, email_buyer, dateBirthday);
                updateForm.ShowDialog();
                UpdateTable("Buyers", dataGridView8);
            }
        }
        private void AddBuyersButton_Click(object sender, EventArgs e)
        {
            AddBuyerForm addBuyerForm = new AddBuyerForm();
            addBuyerForm.ShowDialog();
            UpdateTable("Buyers", dataGridView8);
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
        private void ResetBuyerButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Buyers", dataGridView8);
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView9.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "Sellers", "codesellerDataGridViewTextBoxColumn1", "Code_seller", dataGridView9);
            }
            if (dataGridView9.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id;
                string lastName_seller, firstName_seller, middleName_seller;

                id = Convert.ToInt32(dataGridView9.Rows[e.RowIndex].Cells["codesellerDataGridViewTextBoxColumn1"].Value);
                lastName_seller = Convert.ToString(dataGridView9.Rows[e.RowIndex].Cells["lastNamesellerDataGridViewTextBoxColumn"].Value);
                firstName_seller = Convert.ToString(dataGridView9.Rows[e.RowIndex].Cells["firstNamesellerDataGridViewTextBoxColumn"].Value);
                middleName_seller = Convert.ToString(dataGridView9.Rows[e.RowIndex].Cells["middleNamesellerDataGridViewTextBoxColumn"].Value);
               

                UpdateSellerForm updateForm = new UpdateSellerForm(id, lastName_seller, firstName_seller, middleName_seller);
                updateForm.ShowDialog();
                UpdateTable("Sellers", dataGridView9);
            }
        }
        private void AddSellersButton_Click(object sender, EventArgs e)
        {
            AddSellerForm addSellerForm = new AddSellerForm();
            addSellerForm.ShowDialog();
            UpdateTable("Sellers", dataGridView9);

        }
        private void SearchSellerByIdButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Sellers", "Code_seller", SearchSellerByIdButton.Text, dataGridView9);
        }

        private void SearchSellerBySurnameButton_Click(object sender, EventArgs e)
        {
            SearchDataInTable("Sellers", "LastName_seller", SearchSellerBySurname_textBox.Text, dataGridView9);
        }
        private void ResetSellersButton_Click(object sender, EventArgs e)
        {
            UpdateTable("Sellers", dataGridView9);
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView10.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "UserAuthorization", "userLogincodeDataGridViewTextBoxColumn", "UserLogin_code", dataGridView10);
            }
            if (dataGridView10.Columns[e.ColumnIndex].HeaderText == "Изменить")
            {
                int id;
                string user_login, user_password;

                id = Convert.ToInt32(dataGridView10.Rows[e.RowIndex].Cells["userLogincodeDataGridViewTextBoxColumn"].Value);
                user_login = Convert.ToString(dataGridView10.Rows[e.RowIndex].Cells["userLoginDataGridViewTextBoxColumn"].Value);
                user_password = Convert.ToString(dataGridView10.Rows[e.RowIndex].Cells["userPasswordDataGridViewTextBoxColumn"].Value);


                UpdateUserLoginForm updateForm = new UpdateUserLoginForm(id, user_login, user_password);
                updateForm.ShowDialog();
                UpdateTable("UserAuthorization", dataGridView10);
            }
        }

        private void AddUserLoginButton_Click(object sender, EventArgs e)
        {
            AddUserLoginForm addUserLoginForm = new AddUserLoginForm();
            addUserLoginForm.ShowDialog();
            UpdateTable("UserAuthorization", dataGridView10);
        }
        private void ResetUserLoginButton_Click(object sender, EventArgs e)
        {
            UpdateTable("UserAuthorization", dataGridView10);
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            connectionString = sqlConnection_textBox.Text;
            this.con = new SqlConnection(connectionString);
        }
        private void CreateProcedureButton_Click(object sender, EventArgs e)
        {
            const string createProcedure = 
                "CREATE PROCEDURE CheckLoginValidate @userLogin VARCHAR(max), @userPassword VARCHAR(max) AS " +
                "BEGIN " +
                "SELECT COUNT(*) FROM UserAuthorization WHERE UserLogin = @userLogin AND UserPassword = @userPassword " +
                "END";
            try
            {
                SqlCommand cmd = new SqlCommand(createProcedure,con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void CreateTriggerButton_Click(object sender, EventArgs e)
        {
            const string createTrigger =
                "CREATE TRIGGER PartCostRollback ON Parts AFTER INSERT AS " +
                "BEGIN " +
                "SET NOCOUNT ON; " +
                "IF (SELECT Cost_part FROM inserted) < 0 " +
                "BEGIN " +
                "ROLLBACK " +
                "PRINT 'Вы не можете установить отрицательную стоимость запчасти' " +
                "END " +
                "END";
            try
            {
                SqlCommand cmd = new SqlCommand(createTrigger, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void CreateDataBaseButton_Click(object sender, EventArgs e)
        {
            const string createDB =
                "CREATE TABLE Sellers(Code_seller INT PRIMARY KEY IDENTITY(1,1), LastName_seller VARCHAR(max), FirstName_seller VARCHAR(max), MiddleName_seller VARCHAR(max)) " +
                "CREATE TABLE Buyers(Code_buyer INT PRIMARY KEY IDENTITY(1,1), LastName_buyer VARCHAR(max), FirstName_buyer VARCHAR(max), MiddleName_buyer VARCHAR(max), DateBirthday_buyer DateTime, NumberPhone_buyer VARCHAR(max), Email_buyer VARCHAR(max)) " +
                "CREATE TABLE CategoryParts(Code_category INT PRIMARY KEY IDENTITY(1,1), Name_category VARCHAR(max)) " +
                "CREATE TABLE Manufacturer(Code_manufacturer INT PRIMARY KEY IDENTITY(1,1), Name_manufacturer VARCHAR(max), Address_manufacturer VARCHAR(max), PhoneNumber_manufacturer VARCHAR(max), Email_manufacturer VARCHAR(max)) " +
                "CREATE TABLE ProviderParts(Code_provider INT PRIMARY KEY IDENTITY(1,1), Name_provider VARCHAR(max), Address_provider VARCHAR(max), PhoneNumber_provider VARCHAR(max), Email_provider VARCHAR(max)) " +
                "CREATE TABLE Parts(Code_part INT PRIMARY KEY IDENTITY(1,1), Name_part VARCHAR(max), Type_part VARCHAR(MAX), Category_part INT FOREIGN KEY REFERENCES CategoryParts(Code_category),Cost_part DECIMAL(18,2), Manufacturer INT FOREIGN KEY REFERENCES Manufacturer(Code_manufacturer), Provider_parts INT FOREIGN KEY REFERENCES ProviderParts(Code_provider), Description_part VARCHAR(max)) " +
                "CREATE TABLE Stock(CodePartOn_stock INT PRIMARY KEY IDENTITY(1,1), Code_part INT FOREIGN KEY REFERENCES Parts(Code_part), Count_parts INT) " +
                "CREATE TABLE Sales(Code_sales INT PRIMARY KEY IDENTITY(1,1), Sales_date DATETIME, Code_buyer INT FOREIGN KEY REFERENCES Buyers(Code_buyer), Code_seller INT FOREIGN KEY REFERENCES Sellers(Code_seller)) " +
                "CREATE TABLE SalesItemList(Code_salesItem INT PRIMARY KEY IDENTITY(1,1), Code_sales INT FOREIGN KEY REFERENCES Sales(Code_sales), Code_part INT FOREIGN KEY REFERENCES Parts(Code_part), Part_amount INT) " +
                "CREATE TABLE UserAuthorization(UserLogin_code INT PRIMARY KEY IDENTITY(1,1), UserLogin VARCHAR(max), UserPassword VARCHAR(max)) ";
            try
            {
                SqlCommand cmd = new SqlCommand(createDB, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Таблицы успешно созданы", "OK", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadDataInTableButton_Click(object sender, EventArgs e)
        {
            const string createData =
                "INSERT INTO Sellers(LastName_seller, FirstName_seller, MiddleName_seller) VALUES('Иванов', 'Иван', 'Иванович') " +
                "INSERT INTO Sellers(LastName_seller, FirstName_seller, MiddleName_seller) VALUES('Петров', 'Петр', 'Петрович') " +
                "INSERT INTO Sellers(LastName_seller, FirstName_seller, MiddleName_seller) VALUES('Федоров', 'Федор', 'Федорович') " +
                "INSERT INTO Sellers(LastName_seller, FirstName_seller, MiddleName_seller) VALUES('Семенов', 'Глеб', 'Владимирович') " +
                "INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) VALUES('Силкин', 'Артур', 'Максимович', '2003/13/7', '+79990000001', 'artur2003@mail.ru') " +
                "INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) VALUES('Коленкин', 'Степан', 'Евгеньевич', '2003/23/7', '+79990000002', 'stepan2003@mail.ru') " +
                "INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) VALUES('Прохоров', 'Андрей', 'Евгеньевич', '2003/15/9', '+79990000003', 'andrey2003@mail.ru') " +
                "INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) VALUES('Даниленко', 'Кирилл', 'Андреевич', '2003/15/2', '+79990000004', 'kirill2003@mail.ru') " +
                "INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) VALUES('Семенов', 'Глеб', 'Владимирович', '2003/23/7', '+79990000321', 'gleb2003@mail.ru') " +
                "INSERT INTO Buyers(LastName_buyer, FirstName_buyer, MiddleName_buyer, DateBirthday_buyer, NumberPhone_buyer, Email_buyer) VALUES('Петров', 'Петр', 'Петрович', '2003/23/7', '+79990000323', 'petrov2003@mail.ru') " +
                "INSERT INTO CategoryParts(Name_category) VALUES('Двигатель') " +
                "INSERT INTO CategoryParts(Name_category) VALUES('Детали подвески') " +
                "INSERT INTO CategoryParts(Name_category) VALUES('Детали кузова') " +
                "INSERT INTO CategoryParts(Name_category) VALUES('Детали интерьера') " +
                "INSERT INTO CategoryParts(Name_category) VALUES('Тюнинг') " +
                "INSERT INTO CategoryParts(Name_category) VALUES('Масла и технические жидкости') " +
                "INSERT INTO Manufacturer(Name_manufacturer, Address_manufacturer, PhoneNumber_manufacturer, Email_manufacturer) VALUES('ИП Иванов', 'проспект Мира, 46, Омск, 644050', '+79131231223', 'ivanov@mail.ru') " +
                "INSERT INTO Manufacturer(Name_manufacturer, Address_manufacturer, PhoneNumber_manufacturer, Email_manufacturer) VALUES('ИП Петров', 'проспект Мира, 47, Омск, 644050', '+79131231224', 'petrov@mail.ru') " +
                "INSERT INTO Manufacturer(Name_manufacturer, Address_manufacturer, PhoneNumber_manufacturer, Email_manufacturer) VALUES('ИП Федоров', 'проспект Мира, 48, Омск, 644050', '+79131231225', 'fedorov@mail.ru') " +
                "INSERT INTO ProviderParts(Name_provider, Address_provider, PhoneNumber_provider, Email_provider) VALUES('ИП Семенов', 'проспект Мира, 49, Омск, 644050', '+79131231211', 'ivanov@mail.ru') " +
                "INSERT INTO ProviderParts(Name_provider, Address_provider, PhoneNumber_provider, Email_provider) VALUES('ИП Прохоров', 'проспект Мира, 50, Омск, 644050', '+79131232222', 'prohorov@mail.ru') " +
                "INSERT INTO ProviderParts(Name_provider, Address_provider, PhoneNumber_provider, Email_provider) VALUES('ООО Запчасти', 'проспект Мира, 51, Омск, 644050', '+79131231123', 'ooo.zapchasti@mail.ru') " +
                "INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part) VALUES('2JZ-GTE', 'Двигатель в сборе', 1, 650000, 1, 2, 'Двигатель в хорошем состоянии') " +
                "INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part) VALUES('3S-GTE', 'Двигатель в сборе', 1, 500000, 1, 2, 'Двигатель в хорошем состоянии') " +
                "INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part) VALUES('1NZ-FE', 'Двигатель в сборе', 1, 80000, 1, 2, 'Двигатель в хорошем состоянии') " +
                "INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part) VALUES('Диск кованный R16 4x100', 'Колесный диск', 2, 10000, 2, 1, 'Колесный диск новый кованный') " +
                "INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part) VALUES('Диск кованный R17 4x100', 'Колесный диск', 2, 15000, 2, 1, 'Колесный диск новый кованный') " +
                "INSERT INTO Parts(Name_part, Type_part, Category_part, Cost_part, Manufacturer, Provider_parts, Description_part) VALUES('Диск кованный R18 4x100', 'Колесный диск', 2, 20000, 2, 1, 'Колесный диск новый кованный') " +
                "INSERT INTO Stock(Code_part, Count_parts) VALUES(1, 5) " +
                "INSERT INTO Stock(Code_part, Count_parts) VALUES(2, 15) " +
                "INSERT INTO Stock(Code_part, Count_parts) VALUES(6, 50) " +
                "INSERT INTO Stock(Code_part, Count_parts) VALUES(4, 100) " +
                "INSERT INTO Sales(Sales_date, Code_buyer, Code_seller) VALUES('2023/23/11', 1, 1) " +
                "INSERT INTO Sales(Sales_date, Code_buyer, Code_seller) VALUES('2023/23/11', 2, 2) " +
                "INSERT INTO Sales(Sales_date, Code_buyer, Code_seller) VALUES('2023/23/11', 3, 1) " +
                "INSERT INTO Sales(Sales_date, Code_buyer, Code_seller) VALUES('2023/23/11', 4, 2) " +
                "INSERT INTO SalesItemList(Code_sales, Code_part, Part_amount) VALUES(1, 1, 2) " +
                "INSERT INTO SalesItemList(Code_sales, Code_part, Part_amount) VALUES(2, 3, 4) " +
                "INSERT INTO SalesItemList(Code_sales, Code_part, Part_amount) VALUES(1, 4, 8) " +
                "INSERT INTO UserAuthorization(UserLogin, UserPassword) VALUES('Admin', '1234') " +
                "INSERT INTO UserAuthorization(UserLogin, UserPassword) VALUES('Seller', '1111') ";
            try
            {
                SqlCommand cmd = new SqlCommand(createData, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Строки успешно созданы", "OK", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
