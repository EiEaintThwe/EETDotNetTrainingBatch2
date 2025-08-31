
using EETDotNetTraningBatch2.POSConsoleApp;

Console.WriteLine("Welcome, Mini POS!");

Result:
Console.WriteLine("Menus");
Console.WriteLine("-----------------------------------");
Console.WriteLine("1. Product");
Console.WriteLine("2. Sale");
Console.WriteLine("3. Sale Detail");
Console.WriteLine("4. Exit");

Console.WriteLine("-----------------------------------");

Console.Write("Choose Menu : ");
string result = Console.ReadLine()!;
bool isInt = int.TryParse(result, out int no);
if (!isInt)
{
    Console.WriteLine("Invalid Product Menu. Please choose 1 to 4");
    goto Result;
}

EnumMenu menu = (EnumMenu)no;
switch (menu)
{
  
    case EnumMenu.Product:
        ProductService productService = new ProductService();
        productService.Execute();
        goto Result;
        break;
    case EnumMenu.Sale:
        SaleService saleService = new SaleService();
        saleService.Execute();
        goto Result;
        break;
    case EnumMenu.SaleDetail:
        SaleDetailService saleDetailService = new SaleDetailService();
        saleDetailService.Execute();
        goto Result;
        break;
    case EnumMenu.Exit:
        goto End;
    case EnumMenu.None:
    default:
        Console.WriteLine("Invalid Menu. Please choose 1 to 4");
        goto Result;
}

End:
Console.WriteLine("Exiting Mini POS....");


//ProductService productService = new ProductService();
//productService.Execute();
//productService.Read();
//productService.Edit();
//productService.Create();
//productService.Update();
//productService.Delete();

//SaleDetailService saleDetailService = new SaleDetailService();
//saleDetailService.Read();
//saleDetailService.Edit();
//saleDetailService.Create();

//SaleService saleService = new SaleService();
//saleService.Read();
//saleService.Edit();
//saleService.Create();

//Console.ReadLine();

//Console.ReadKey();
