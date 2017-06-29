using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryEntityTest.Data;

namespace GroceryEntityTest
{
    public class LinqUpdateCalls
    {
        public void UpdateBeer(BeerData beerData, BeerBarcode beerBarData, double productArticle) //Info passed back to Form1 where it is linked to the textboxes
        {
            //LINQ query to the database where the products in the update textboxes are populated back to the DB
            using (var context = new GroceryTestDBEntities())
            {
                var query = from s in context.BeerDatas
                            where s.Article == productArticle
                            select s;
                var query1 = from s in context.BeerBarcodes
                             where s.Article == productArticle
                             select s;
                var beerProducts = query.FirstOrDefault();
                var beerProductswithBarcode = query1.FirstOrDefault();

                beerProducts.Article = beerData.Article;
                beerProducts.Article_Description = beerData.Article_Description;
                beerProductswithBarcode.Article = beerBarData.Article;
                beerProductswithBarcode.Barcode = beerBarData.Barcode;
                beerProducts.Storage_Bin = beerData.Storage_Bin;
                beerProducts.Department = beerData.Department;
                beerProducts.Sub_Department = beerData.Sub_Department;

                context.SaveChanges();
            }
        }

        public void UpdateGrocery(GroceryData groceryData, GroceryBarcode groceryBarData, double productArticle) //Info passed back to Form1 where it is linked to the textboxes
        {
            //LINQ query to the database where the products in the update textboxes are populated back to the DB
            using (var context = new GroceryTestDBEntities())
            {
                var query = from s in context.GroceryDatas
                            where s.Article == productArticle
                            select s;
                var query1 = from s in context.GroceryBarcodes
                             where s.Article == productArticle
                             select s;
                var groceryProducts = query.FirstOrDefault();
                var groceryProductsWithBarcode = query1.FirstOrDefault();

                groceryProducts.Article = groceryData.Article;
                groceryProducts.Article_Description = groceryData.Article_Description;
                groceryProductsWithBarcode.Article = groceryBarData.Article;
                groceryProductsWithBarcode.Barcode = groceryBarData.Barcode;
                groceryProducts.Storage_Bin = groceryData.Storage_Bin;
                groceryProducts.Department = groceryData.Department;
                groceryProducts.Sub_Department = groceryData.Sub_Department;

                context.SaveChanges();
            }
        }

        public void UpdateWine(WineData wineData, WineBarcode wineBarData, double productArticle) //Info passed back to Form1 where it is linked to the textboxes
        {
            //LINQ query to the database where the products in the update textboxes are populated back to the DB
            using (var context = new GroceryTestDBEntities())
            {
                var query = from s in context.WineDatas
                            where s.Article == productArticle
                            select s;
                var query1 = from s in context.WineBarcodes
                             where s.Article == productArticle
                             select s;
                var wineProducts = query.FirstOrDefault();
                var wineProductsWithBarcode = query1.FirstOrDefault();

                wineProducts.Article = wineData.Article;
                wineProducts.Article_Description = wineData.Article_Description;
                wineProductsWithBarcode.Article = wineBarData.Article;
                wineProductsWithBarcode.Barcode = wineBarData.Barcode;
                wineProducts.Storage_Bin = wineData.Storage_Bin;
                wineProducts.Department = wineData.Department;
                wineProducts.Sub_Department = wineData.Sub_Department;

                context.SaveChanges();
            }
        }

        public void UpdateDairy(DairyData dairyData, DairyBarcode dairyBarData, double productArticle) //Info passed back to Form1 where it is linked to the textboxes
        {
            //LINQ query to the database where the products in the update textboxes are populated back to the DB
            using (var context = new GroceryTestDBEntities())
            {
                var query = from s in context.DairyDatas
                            where s.Article == productArticle
                            select s;
                var query1 = from s in context.DairyBarcodes
                             where s.Article == productArticle
                             select s;
                var dairyProducts = query.FirstOrDefault();
                var dairyProductsWithBarcode = query1.FirstOrDefault();

                dairyProducts.Article = dairyData.Article;
                dairyProducts.Article_Description = dairyData.Article_Description;
                dairyProductsWithBarcode.Article = dairyBarData.Article;
                dairyProductsWithBarcode.Barcode = dairyBarData.Barcode;
                dairyProducts.Storage_Bin = dairyData.Storage_Bin;
                dairyProducts.Department = dairyData.Department;
                dairyProducts.Sub_Department = dairyData.Sub_Department;

                context.SaveChanges();
            }
        }

        public void UpdateFrozen(FrozenData frozenData, FrozenBarcode frozenBarData, double productArticle) //Info passed back to Form1 where it is linked to the textboxes
        {
            //LINQ query to the database where the products in the update textboxes are populated back to the DB
            using (var context = new GroceryTestDBEntities())
            {
                var query = from s in context.FrozenDatas
                            where s.Article == productArticle
                            select s;
                var query1 = from s in context.FrozenBarcodes
                             where s.Article == productArticle
                             select s;
                var frozenProducts = query.FirstOrDefault();
                var frozenProductsWithBarcode = query1.FirstOrDefault();

                frozenProducts.Article = frozenData.Article;
                frozenProducts.Article_Description = frozenData.Article_Description;
                frozenProductsWithBarcode.Article = frozenBarData.Article;
                frozenProductsWithBarcode.Barcode = frozenBarData.Barcode;
                frozenProducts.Storage_Bin = frozenData.Storage_Bin;
                frozenProducts.Department = frozenData.Department;
                frozenProducts.Sub_Department = frozenData.Sub_Department;

                context.SaveChanges();
            }
        }

        public void UpdateGM(GMData gmData, GMBarcode gmBarData, double productArticle) //Info passed back to Form1 where it is linked to the textboxes
        {
            //LINQ query to the database where the products in the update textboxes are populated back to the DB
            using (var context = new GroceryTestDBEntities())
            {
                var query = from s in context.GMDatas
                            where s.Article == productArticle
                            select s;
                var query1 = from s in context.GMBarcodes
                             where s.Article == productArticle
                             select s;
                var gmProducts = query.FirstOrDefault();
                var gmProductsWithBarcode = query1.FirstOrDefault();

                gmProducts.Article = gmData.Article;
                gmProducts.Article_Description = gmData.Article_Description;
                gmProductsWithBarcode.Article = gmBarData.Article;
                gmProductsWithBarcode.EAN_UPC = gmBarData.EAN_UPC;
                gmProducts.Storage_Bin = gmData.Storage_Bin;
                gmProducts.Department = gmData.Department;
                gmProducts.Sub_Department = gmData.Sub_Department;

                context.SaveChanges();
            }
        }
    }
}
