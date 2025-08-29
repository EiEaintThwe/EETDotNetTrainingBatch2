
using EETDotNetTraningBatch2.POSConsoleApp;

Console.WriteLine("Hello, World!");

//ProductService productService = new ProductService();
//productService.Read();
//productService.Edit();
//productService.Create();
//productService.Update();
//productService.Delete();

SaleDetailService saleDetailService = new SaleDetailService();
//saleDetailService.Read();
//saleDetailService.Edit();
//saleDetailService.Create();

SaleService saleService = new SaleService();
saleService.Read();
saleService.Edit();
//saleService.Create();

Console.ReadKey();
