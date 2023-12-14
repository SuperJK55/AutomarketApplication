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
        private void AddChecksButton_Click(object sender, EventArgs e)
        {
            AddChecksForm addChecksForm = new AddChecksForm();
            addChecksForm.ShowDialog();
            UpdateTable("SalesItemList", dataGridView7);
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView8.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                DeleteButtonTable(e, "SalesItemList", "codesalesItemDataGridViewTextBoxColumn", "Code_salesItem", dataGridView8);
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

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            
            connectionString = sqlConnection_textBox.Text;
            this.con = new SqlConnection(connectionString);
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
    }
}
