using System;
using System.Collections.Generic;

namespace EETDotNetTraningBatch2.WinFormsApp1.Database.App3DbContextModels;

public partial class TblSaleDetail
{
    public int SaleDetailId { get; set; }

    public int SaleId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
