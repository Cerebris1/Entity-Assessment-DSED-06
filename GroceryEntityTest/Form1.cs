using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryEntityTest.Data;

namespace GroceryEntityTest
{
    public partial class Form1 : Form
    {
        // Instantiate the required classes
        ChooseDepartmentClass myDepartment = new ChooseDepartmentClass();
        LinqUpdateCalls myLinqUpdateCalls = new LinqUpdateCalls();

        public Form1()
        {
            InitializeComponent();
            LoadAllProducts(); //Loads all products from the AllProductsAllDatas view into the gridview
            cbxDepartment.DataSource = myDepartment.GetDepartment(); // Select a department from the myDepartment class
        }

        public void LoadAllProducts() //Loads all products from the AllDeptsAllProductsAllDatas view into the gridview
        {
            using (var context = new GroceryTestDBEntities())
            {
                var c = from a in context.AllDeptsAllProductsAllDatas
                        select a;
                // Populate results to the DGV
                dgvProducts.DataSource = c.ToList();

                SelectDepartment(); // Reset and select the current selected department
            }
        }

        public void RefreshDGV()
        {
            LoadAllProducts();
        }

        public void SelectDepartment() // Select a department from the myDepartment class
        {
            using (var context = new GroceryTestDBEntities())
            {
                var c = from a in context.AllDeptsAllProductsAllDatas
                        where a.Department == cbxDepartment.Text
                        select a;
                // Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        public void ClearAddTextBoxes() //Clear all Add textboxes
        {
            txtAddArticle.Clear();
            txtAddDesc.Clear();
            txtAddBarcode.Clear();
            txtAddStorage.Clear();
            txtAddDept.Clear();
            txtAddSubDept.Clear();
        }

        public void ClearUpdateTextBoxes() //Clear all Update textboxes
        {
            txtUpdateArticle.Clear();
            txtUpdateDesc.Clear();
            txtUpdateBarcode.Clear();
            txtUpdateStorage.Clear();
            txtUpdateDept.Clear();
            txtUpdateSubDept.Clear();
        }

        private void btnBarcodeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                AllBarcodesSearch();
            }

            catch
            {
                MessageBox.Show("Please enter in a barcode");
            }
        }

        private void btnDescriptionSearch_Click(object sender, EventArgs e)
        {
            // Try and search for a description and if return error message if unable
            try
            {
                if (cbxDepartment.Text == "Grocery")
                {
                    SearchGroceryProduct();
                }

                if (cbxDepartment.Text == "Beer")
                {
                    SearchBeerProduct();
                }

                if (cbxDepartment.Text == "Wine")
                {
                    SearchWineProduct();
                }

                if (cbxDepartment.Text == "Dairy")
                {
                    SearchDairyProduct();
                }

                if (cbxDepartment.Text == "Frozen")
                {
                    SearchFrozenProduct();
                }

                if (cbxDepartment.Text == "General Merchandise")
                {
                    SearchGMProduct();
                }
            }

            catch
            {
                MessageBox.Show("Please enter in a product description");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Try and add a product to the DB and if return error message if unable
            try
            {
                if (cbxDepartment.Text == "Grocery")
                {
                    AddGroceryProduct();
                }

                if (cbxDepartment.Text == "Beer")
                {
                    AddBeerProduct();
                }

                if (cbxDepartment.Text == "Wine")
                {
                    AddWineProduct();
                }

                if (cbxDepartment.Text == "Dairy")
                {
                    AddDairyProduct();
                }

                if (cbxDepartment.Text == "Frozen")
                {
                    AddFrozenProduct();
                }

                if (cbxDepartment.Text == "General Merchandise")
                {
                    AddGMProduct();
                }
            }

            catch
            {
                MessageBox.Show("Please check and ensure numbers and letters are in the correct text boxes, ie: No letters in the barcode box.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Try and update an existing product to the DB and if return error message if unable
            try
            {
                if (cbxDepartment.Text == "Grocery")
                {
                    UpdateGroceryProduct();
                }

                if (cbxDepartment.Text == "Beer")
                {
                    UpdateBeerProduct();
                }

                if (cbxDepartment.Text == "Wine")
                {
                    UpdateWineProduct();
                }

                if (cbxDepartment.Text == "Dairy")
                {
                    UpdateDairyProduct();
                }

                if (cbxDepartment.Text == "Frozen")
                {
                    UpdateFrozenProduct();
                }

                if (cbxDepartment.Text == "General Merchandise")
                {
                    UpdateGMProduct();
                }
            }

            catch
            {
                MessageBox.Show("Please enter in full product details.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Try and delete a product from the DB and if return error message if unable
            try
            {
                if (cbxDepartment.Text == "Grocery")
                {
                    DeleteGroceryProduct();
                }

                if (cbxDepartment.Text == "Beer")
                {
                    DeleteBeerProduct();
                }

                if (cbxDepartment.Text == "Wine")
                {
                    DeleteWineProduct();
                }

                if (cbxDepartment.Text == "Dairy")
                {
                    DeleteDairyProduct();
                }

                if (cbxDepartment.Text == "Frozen")
                {
                    DeleteFrozenProduct();
                }

                if (cbxDepartment.Text == "General Merchandise")
                {
                    DeleteGMProduct();
                }
            }

            catch
            {
                MessageBox.Show("Please enter in full product details.");
            }

        }

        private void AllBarcodesSearch() // Search for all barcodes in DB and return the result
        {
            using (var context = new GroceryTestDBEntities())
            {
                // Sets a variable to the barcode text box
                double barcode = Convert.ToDouble(txtBarcode.Text);

                //LINQ query to the database for where the barcode inputted matches the one in the DB then return a display
                var c = from a in context.AllDeptsAllProductsAllDatas
                        where a.Barcode == barcode
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void SearchBeerProduct()
        {
            using (var context = new GroceryTestDBEntities())
            {
                //Sets a variable to the description text box
                string description = txtDescription.Text;

                //LINQ query to the database where the description inputted matches the one in the DB then display
                var c = from a in context.BeerAllProductsAllDatas
                        where a.Article_Description.Contains(description)
                        orderby a.Article_Description ascending
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void SearchGroceryProduct()
        {
            using (var context = new GroceryTestDBEntities())
            {
                //Sets a variable to the description text box
                string description = txtDescription.Text;

                //LINQ query to the database where the description inputted matches the one in the DB then display
                var c = from a in context.GroceryAllProductsAllDatas
                        where a.Article_Description.Contains(description)
                        orderby a.Article_Description ascending
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void SearchWineProduct()
        {
            using (var context = new GroceryTestDBEntities())
            {
                //Sets a variable to the description text box
                string description = txtDescription.Text;

                //LINQ query to the database where the description inputted matches the one in the DB then display
                var c = from a in context.WineAllProductsAllDatas
                        where a.Article_Description.Contains(description)
                        orderby a.Article_Description ascending
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void SearchDairyProduct()
        {
            using (var context = new GroceryTestDBEntities())
            {
                //Sets a variable to the description text box
                string description = txtDescription.Text;

                //LINQ query to the database where the description inputted matches the one in the DB then display
                var c = from a in context.DairyAllProductsAllDatas
                        where a.Article_Description.Contains(description)
                        orderby a.Article_Description ascending
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void SearchFrozenProduct()
        {
            using (var context = new GroceryTestDBEntities())
            {
                //Sets a variable to the description text box
                string description = txtDescription.Text;

                //LINQ query to the database where the description inputted matches the one in the DB then display
                var c = from a in context.FrozenAllProductsAllDatas
                        where a.Article_Description.Contains(description)
                        orderby a.Article_Description ascending
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void SearchGMProduct()
        {
            using (var context = new GroceryTestDBEntities())
            {
                //Sets a variable to the description text box
                string description = txtDescription.Text;

                //LINQ query to the database where the description inputted matches the one in the DB then display
                var c = from a in context.GMAllProductsAllDatas
                        where a.Article_Description.Contains(description)
                        orderby a.Article_Description ascending
                        select a;
                //Populate results to the DGV
                dgvProducts.DataSource = c.ToList();
            }
        }

        private void AddBeerProduct()
        {
            // Adds products to the DB based off what is entered into the text boxes
            using (var context = new GroceryTestDBEntities())
            {
                var products = new BeerData();
                var productbarcode = new BeerBarcode();
                products.Article = Convert.ToDouble(txtAddArticle.Text);
                products.Article_Description = txtAddDesc.Text;
                productbarcode.Article = Convert.ToDouble(txtAddArticle.Text);
                productbarcode.Barcode = Convert.ToDouble(txtAddBarcode.Text);
                products.Storage_Bin = txtAddStorage.Text;
                products.Department = txtAddDept.Text;
                products.Sub_Department = txtAddSubDept.Text;
                MessageBox.Show(products.Article_Description + " was added to the Database.");

                context.BeerDatas.Add(products);
                context.BeerBarcodes.Add(productbarcode);
                context.SaveChanges();

                ClearAddTextBoxes();
            }
        }

        private void AddGroceryProduct()
        {
            // Adds products to the DB based off what is entered into the text boxes
            using (var context = new GroceryTestDBEntities())
            {
                var products = new GroceryData();
                var productbarcode = new GroceryBarcode();
                products.Article = Convert.ToDouble(txtAddArticle.Text);
                products.Article_Description = txtAddDesc.Text;
                productbarcode.Article = Convert.ToDouble(txtAddArticle.Text);
                productbarcode.Barcode = Convert.ToDouble(txtAddBarcode.Text);
                products.Storage_Bin = txtAddStorage.Text;
                products.Department = txtAddDept.Text;
                products.Sub_Department = txtAddSubDept.Text;
                MessageBox.Show(products.Article_Description + " was added to the Database.");

                context.GroceryDatas.Add(products);
                context.GroceryBarcodes.Add(productbarcode);
                context.SaveChanges();

                ClearAddTextBoxes();
            }
        }

        private void AddWineProduct()
        {
            // Adds products to the DB based off what is entered into the text boxes
            using (var context = new GroceryTestDBEntities())
            {
                var products = new WineData();
                var productbarcode = new WineBarcode();
                products.Article = Convert.ToDouble(txtAddArticle.Text);
                products.Article_Description = txtAddDesc.Text;
                productbarcode.Article = Convert.ToDouble(txtAddArticle.Text);
                productbarcode.Barcode = Convert.ToDouble(txtAddBarcode.Text);
                products.Storage_Bin = txtAddStorage.Text;
                products.Department = txtAddDept.Text;
                products.Sub_Department = txtAddSubDept.Text;
                MessageBox.Show(products.Article_Description + " was added to the Database.");

                context.WineDatas.Add(products);
                context.WineBarcodes.Add(productbarcode);
                context.SaveChanges();

                ClearAddTextBoxes();
            }
        }

        private void AddDairyProduct()
        {
            // Adds products to the DB based off what is entered into the text boxes
            using (var context = new GroceryTestDBEntities())
            {
                var products = new DairyData();
                var productbarcode = new DairyBarcode();
                products.Article = Convert.ToDouble(txtAddArticle.Text);
                products.Article_Description = txtAddDesc.Text;
                productbarcode.Article = Convert.ToDouble(txtAddArticle.Text);
                productbarcode.Barcode = Convert.ToDouble(txtAddBarcode.Text);
                products.Storage_Bin = txtAddStorage.Text;
                products.Department = txtAddDept.Text;
                products.Sub_Department = txtAddSubDept.Text;
                MessageBox.Show(products.Article_Description + " was added to the Database.");

                context.DairyDatas.Add(products);
                context.DairyBarcodes.Add(productbarcode);
                context.SaveChanges();

                ClearAddTextBoxes();
            }
        }

        private void AddFrozenProduct()
        {
            // Adds products to the DB based off what is entered into the text boxes
            using (var context = new GroceryTestDBEntities())
            {
                var products = new FrozenData();
                var productbarcode = new FrozenBarcode();
                products.Article = Convert.ToDouble(txtAddArticle.Text);
                products.Article_Description = txtAddDesc.Text;
                productbarcode.Article = Convert.ToDouble(txtAddArticle.Text);
                productbarcode.Barcode = Convert.ToDouble(txtAddBarcode.Text);
                products.Storage_Bin = txtAddStorage.Text;
                products.Department = txtAddDept.Text;
                products.Sub_Department = txtAddSubDept.Text;
                MessageBox.Show(products.Article_Description + " was added to the Database.");

                context.FrozenDatas.Add(products);
                context.FrozenBarcodes.Add(productbarcode);
                context.SaveChanges();

                ClearAddTextBoxes();
            }
        }

        private void AddGMProduct()
        {
            // Adds products to the DB based off what is entered into the text boxes
            using (var context = new GroceryTestDBEntities())
            {
                var products = new GMData();
                var productbarcode = new GMBarcode();
                products.Article = Convert.ToDouble(txtAddArticle.Text);
                products.Article_Description = txtAddDesc.Text;
                productbarcode.Article = Convert.ToDouble(txtAddArticle.Text);
                productbarcode.EAN_UPC = Convert.ToDouble(txtAddBarcode.Text);
                products.Storage_Bin = txtAddStorage.Text;
                products.Department = txtAddDept.Text;
                products.Sub_Department = txtAddSubDept.Text;
                MessageBox.Show(products.Article_Description + " was added to the Database.");

                context.GMDatas.Add(products);
                context.GMBarcodes.Add(productbarcode);
                context.SaveChanges();

                ClearAddTextBoxes();
            }
        }

        private void UpdateBeerProduct()
        {
            // Update the products in the DB based off what is entered into the update textboxes
            BeerData beerProducts = new BeerData();
            BeerBarcode beerProductsWithBarcode = new BeerBarcode();
            double article = Convert.ToDouble(txtUpdateArticle.Text);

            beerProducts.Article = Convert.ToDouble(txtUpdateArticle.Text);
            beerProducts.Article_Description = txtUpdateDesc.Text;
            beerProductsWithBarcode.Article = Convert.ToDouble(txtUpdateArticle.Text);
            beerProductsWithBarcode.Barcode = Convert.ToDouble(txtUpdateBarcode.Text);
            beerProducts.Storage_Bin = txtUpdateStorage.Text;
            beerProducts.Department = txtUpdateDept.Text;
            beerProducts.Sub_Department = txtUpdateSubDept.Text;

            myLinqUpdateCalls.UpdateBeer(beerProducts, beerProductsWithBarcode, article);
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
            RefreshDGV();
        }

        private void UpdateGroceryProduct()
        {
            // Update the products in the DB based off what is entered into the update textboxes
            GroceryData groceryProducts = new GroceryData();
            GroceryBarcode groceryProductsWithBarcode = new GroceryBarcode();
            double article = Convert.ToDouble(txtUpdateArticle.Text);

            groceryProducts.Article = Convert.ToDouble(txtUpdateArticle.Text);
            groceryProducts.Article_Description = txtUpdateDesc.Text;
            groceryProductsWithBarcode.Article = Convert.ToDouble(txtUpdateArticle.Text);
            groceryProductsWithBarcode.Barcode = Convert.ToDouble(txtUpdateBarcode.Text);
            groceryProducts.Storage_Bin = txtUpdateStorage.Text;
            groceryProducts.Department = txtUpdateDept.Text;
            groceryProducts.Sub_Department = txtUpdateSubDept.Text;

            myLinqUpdateCalls.UpdateGrocery(groceryProducts, groceryProductsWithBarcode, article);
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
            RefreshDGV();
        }

        private void UpdateWineProduct()
        {
            // Update the products in the DB based off what is entered into the update textboxes
            WineData wineProducts = new WineData();
            WineBarcode wineProductsWithBarcode = new WineBarcode();
            double article = Convert.ToDouble(txtUpdateArticle.Text);

            wineProducts.Article = Convert.ToDouble(txtUpdateArticle.Text);
            wineProducts.Article_Description = txtUpdateDesc.Text;
            wineProductsWithBarcode.Article = Convert.ToDouble(txtUpdateArticle.Text);
            wineProductsWithBarcode.Barcode = Convert.ToDouble(txtUpdateBarcode.Text);
            wineProducts.Storage_Bin = txtUpdateStorage.Text;
            wineProducts.Department = txtUpdateDept.Text;
            wineProducts.Sub_Department = txtUpdateSubDept.Text;

            myLinqUpdateCalls.UpdateWine(wineProducts, wineProductsWithBarcode, article);
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
            RefreshDGV();
        }

        private void UpdateDairyProduct()
        {
            // Update the products in the DB based off what is entered into the update textboxes
            DairyData dairyProducts = new DairyData();
            DairyBarcode dairyProductsWithBarcode = new DairyBarcode();
            double article = Convert.ToDouble(txtUpdateArticle.Text);

            dairyProducts.Article = Convert.ToDouble(txtUpdateArticle.Text);
            dairyProducts.Article_Description = txtUpdateDesc.Text;
            dairyProductsWithBarcode.Article = Convert.ToDouble(txtUpdateArticle.Text);
            dairyProductsWithBarcode.Barcode = Convert.ToDouble(txtUpdateBarcode.Text);
            dairyProducts.Storage_Bin = txtUpdateStorage.Text;
            dairyProducts.Department = txtUpdateDept.Text;
            dairyProducts.Sub_Department = txtUpdateSubDept.Text;

            myLinqUpdateCalls.UpdateDairy(dairyProducts, dairyProductsWithBarcode, article);
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
            RefreshDGV();

        }

        private void UpdateFrozenProduct()
        {
            // Update the products in the DB based off what is entered into the update textboxes
            FrozenData frozenProducts = new FrozenData();
            FrozenBarcode frozenProductsWithBarcode = new FrozenBarcode();
            double article = Convert.ToDouble(txtUpdateArticle.Text);

            frozenProducts.Article = Convert.ToDouble(txtUpdateArticle.Text);
            frozenProducts.Article_Description = txtUpdateDesc.Text;
            frozenProductsWithBarcode.Article = Convert.ToDouble(txtUpdateArticle.Text);
            frozenProductsWithBarcode.Barcode = Convert.ToDouble(txtUpdateBarcode.Text);
            frozenProducts.Storage_Bin = txtUpdateStorage.Text;
            frozenProducts.Department = txtUpdateDept.Text;
            frozenProducts.Sub_Department = txtUpdateSubDept.Text;

            myLinqUpdateCalls.UpdateFrozen(frozenProducts, frozenProductsWithBarcode, article);
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
            RefreshDGV();
        }

        private void UpdateGMProduct()
        {
            // Update the products in the DB based off what is entered into the update textboxes
            GMData gmProducts = new GMData();
            GMBarcode gmProductsWithBarcode = new GMBarcode();
            double article = Convert.ToDouble(txtUpdateArticle.Text);

            gmProducts.Article = Convert.ToDouble(txtUpdateArticle.Text);
            gmProducts.Article_Description = txtUpdateDesc.Text;
            gmProductsWithBarcode.Article = Convert.ToDouble(txtUpdateArticle.Text);
            gmProductsWithBarcode.EAN_UPC = Convert.ToDouble(txtUpdateBarcode.Text);
            gmProducts.Storage_Bin = txtUpdateStorage.Text;
            gmProducts.Department = txtUpdateDept.Text;
            gmProducts.Sub_Department = txtUpdateSubDept.Text;

            myLinqUpdateCalls.UpdateGM(gmProducts, gmProductsWithBarcode, article);
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
            RefreshDGV();
        }

        private void DeleteBeerProduct()
        {
            //Deletes products from the DB based off the article number in the update article textbox
            using (var context = new GroceryTestDBEntities())
            {
                double article = Convert.ToDouble(txtUpdateArticle.Text);

                var products = (from p in context.BeerDatas
                                where p.Article == article
                                select p).SingleOrDefault();

                MessageBox.Show("This will delete " + article + " from the database.");
                context.BeerDatas.Remove(products);
                context.SaveChanges();

                ClearAddTextBoxes();
                ClearUpdateTextBoxes();
                RefreshDGV();
            }
        }

        private void DeleteGroceryProduct()
        {
            //Deletes products from the DB based off the article number in the update article textbox
            using (var context = new GroceryTestDBEntities())
            {
                double article = Convert.ToDouble(txtUpdateArticle.Text);

                var products = (from p in context.GroceryDatas
                                where p.Article == article
                                select p).SingleOrDefault();

                MessageBox.Show("This will delete " + article + " from the database.");
                context.GroceryDatas.Remove(products);
                context.SaveChanges();

                ClearAddTextBoxes();
                ClearUpdateTextBoxes();
                RefreshDGV();
            }
        }

        private void DeleteWineProduct()
        {
            //Deletes products from the DB based off the article number in the update article textbox
            using (var context = new GroceryTestDBEntities())
            {
                double article = Convert.ToDouble(txtUpdateArticle.Text);

                var products = (from p in context.WineDatas
                                where p.Article == article
                                select p).SingleOrDefault();

                MessageBox.Show("This will delete " + article + " from the database.");
                context.WineDatas.Remove(products);
                context.SaveChanges();

                ClearAddTextBoxes();
                ClearUpdateTextBoxes();
                RefreshDGV();
            }
        }

        private void DeleteDairyProduct()
        {
            //Deletes products from the DB based off the article number in the update article textbox
            using (var context = new GroceryTestDBEntities())
            {
                double article = Convert.ToDouble(txtUpdateArticle.Text);

                var products = (from p in context.DairyDatas
                                where p.Article == article
                                select p).SingleOrDefault();

                MessageBox.Show("This will delete " + article + " from the database.");
                context.DairyDatas.Remove(products);
                context.SaveChanges();

                ClearAddTextBoxes();
                ClearUpdateTextBoxes();
                RefreshDGV();
            }
        }

        private void DeleteFrozenProduct()
        {
            //Deletes products from the DB based off the article number in the update article textbox
            using (var context = new GroceryTestDBEntities())
            {
                double article = Convert.ToDouble(txtUpdateArticle.Text);

                var products = (from p in context.FrozenDatas
                                where p.Article == article
                                select p).SingleOrDefault();

                MessageBox.Show("This will delete " + article + " from the database.");
                context.FrozenDatas.Remove(products);
                context.SaveChanges();

                ClearAddTextBoxes();
                ClearUpdateTextBoxes();
                RefreshDGV();
            }
        }

        private void DeleteGMProduct()
        {
            //Deletes products from the DB based off the article number in the update article textbox
            using (var context = new GroceryTestDBEntities())
            {
                double article = Convert.ToDouble(txtUpdateArticle.Text);

                var products = (from p in context.GMDatas
                                where p.Article == article
                                select p).SingleOrDefault();

                MessageBox.Show("This will delete " + article + " from the database.");
                context.GMDatas.Remove(products);
                context.SaveChanges();

                ClearAddTextBoxes();
                ClearUpdateTextBoxes();
                RefreshDGV();
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Whatever comes up in the cell click is copied to the update textboxes
            try
            {
                int rowIndex = e.RowIndex;

                DataGridViewRow row = dgvProducts.Rows[rowIndex];

                txtUpdateArticle.Text = row.Cells[0].Value.ToString();
                txtUpdateDesc.Text = row.Cells[1].Value.ToString();
                txtUpdateBarcode.Text = row.Cells[2].Value.ToString();
                txtUpdateStorage.Text = row.Cells[3].Value.ToString();
                txtUpdateDept.Text = row.Cells[4].Value.ToString();
                txtUpdateSubDept.Text = row.Cells[5].Value.ToString();
            }

            catch
            {

            }
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDepartment();
            ClearAddTextBoxes();
            ClearUpdateTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            ClearUpdateTextBoxes();
            ClearAddTextBoxes();
            txtBarcode.Clear();
            txtDescription.Clear();
        }
    }
}
