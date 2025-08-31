using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POSConsoleApp
{
    public class ProductService
    {
        public void Read()
        {
            App3DbContext db = new App3DbContext();
            List<TblProduct> lst = db.TblProducts.Where(x => x.DeleteFlag == false).ToList();
            foreach (var item in lst)
            {
                Console.WriteLine("Product ID => " + item.ProductId);
                Console.WriteLine("Product Code => " + item.ProductCode);
                Console.WriteLine("Product Name => " + item.ProductName);
                Console.WriteLine("Product Price => " + item.Price);
            }

        }

        public void Edit()
        {
            Console.Write("Enter Product Id : ");
            string productId = Console.ReadLine()!;
            bool isInt = int.TryParse(productId, out int id);
            if (!isInt)
            {
                return;
            }

            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.ProductId == id);
            if (item is null)
            {
                return;
            }
            Console.WriteLine("Product ID => " + item.ProductId);
            Console.WriteLine("Product Code => " + item.ProductCode);
            Console.WriteLine("Product Name => " + item.ProductName);
            Console.WriteLine("Product Price => " + item.Price);

        }

        public void Create()
        {
            Console.Write("Enter Product Code : ");
            string productCode = Console.ReadLine()!;
            Console.Write("Enter Product Name : ");
            string productName = Console.ReadLine()!;
            Console.Write("Enter Product Price : ");
            string productPrice = Console.ReadLine()!;
            bool isDec = decimal.TryParse(productPrice, out decimal price);
            if (!isDec) { return; }

            TblProduct product = new TblProduct()
            {
                ProductCode = productCode,
                ProductName = productName,
                Price = price
            };

            App3DbContext db = new App3DbContext();
            db.TblProducts.Add(product);
            var result = db.SaveChanges();
            Console.WriteLine(result > 0 ? "Saving Successful!" : "Saving Failed!");

        }

        public void Update()
        {
            Console.Write("Enter Product Id : ");
            string productId = Console.ReadLine()!;
            bool isInt = int.TryParse(productId, out int id);
            if (!isInt)
            {
                return;
            }

            Console.Write("Modify Product Code : ");
            string productCode = Console.ReadLine()!;
            Console.Write("Modify Product Name : ");
            string productName = Console.ReadLine()!;
            Console.Write("Modify Product Price : ");
            string productPrice = Console.ReadLine()!;
            bool isDec = decimal.TryParse(productPrice, out decimal price);
            if (!isDec) { return; }

            bool isExit = IsExistProduct(id);
            if (!isExit) { return; }

            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.ProductId == id);
            item.ProductCode = productCode;
            item.ProductName = productName;
            item.Price = price;
            var result = db.SaveChanges();
            Console.WriteLine(result > 0 ? "Updating successful" : "Updating failed");



        }

        public void Delete()
        {
            Console.Write("Enter Product Id : ");
            string productId = Console.ReadLine()!;
            bool isInt = int.TryParse(productId, out int id);
            if (!isInt)
            {
                return;
            }

            bool isExit = IsExistProduct(id);
            if (!isExit) { return; }

            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.ProductId == id);
            item.DeleteFlag = true;
            var result = db.SaveChanges();
            Console.WriteLine(result > 0 ? "Deleting successful" : "Deleting failed");

        }

        private bool IsExistProduct(int id)
        {
            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.FirstOrDefault(x => x.ProductId == id);
            return item != null;



        }

        public void Execute()
        {
        Result:
            Console.WriteLine("Product Menu");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. New Product");
            Console.WriteLine("2. Product List");
            Console.WriteLine("3. Edit Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");

            Console.WriteLine("-----------------------------------");

            Console.Write("Choose Menu : ");
            string result = Console.ReadLine()!;
            bool isInt = int.TryParse(result, out int no);
            if (!isInt)
            {
                Console.WriteLine("Invalid Product Menu. Please choose 1 to 4");
                goto Result;
            }
            Console.WriteLine("-----------------------------------");

            EnumProductMenu menu = (EnumProductMenu)no;
            switch (menu)
            {
               
                case EnumProductMenu.NewProduct:
                    Console.WriteLine("This menu is NewProduct.");
                    Console.WriteLine("-----------------------------------");
                    Create();
                    Console.WriteLine("-----------------------------------");
                    break;
                case EnumProductMenu.ProductList:
                    Console.WriteLine("This menu is ProductList.");
                    Console.WriteLine("-----------------------------------");
                    Read();
                    Console.WriteLine("-----------------------------------");

                    break;
                case EnumProductMenu.EditProduct:
                    Console.WriteLine("This menu is EditProduct.");
                    Console.WriteLine("-----------------------------------");
                    Update();
                    Console.WriteLine("-----------------------------------");
                    break;
                case EnumProductMenu.DeleteProduct:
                    Console.WriteLine("This menu is DeleteProduct.");
                    Console.WriteLine("-----------------------------------");
                    Delete();
                    Console.WriteLine("-----------------------------------");
                    break;

                case EnumProductMenu.Exit:
                    goto End;
                case EnumProductMenu.None:
                default:
                    Console.WriteLine("Invalid Product Menu. Please choose 1 to 5");
                    goto Result;
            }
            Console.WriteLine("-----------------------------------");
            goto Result;

        End:
            Console.WriteLine("Exiting Product Menu....");
        }
    }

    public enum EnumProductMenu
    {
        None,
        NewProduct,
        ProductList,
        EditProduct,
        DeleteProduct,
        Exit
    }

    public enum EnumMenu
    {
        None,
        Product,
        Sale,
        SaleDetail,
        Exit
    }

}
