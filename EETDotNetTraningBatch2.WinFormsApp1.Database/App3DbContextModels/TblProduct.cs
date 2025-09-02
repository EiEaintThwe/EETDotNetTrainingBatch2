using System;
using System.Collections.Generic;

namespace EETDotNetTraningBatch2.WinFormsApp1.Database.App3DbContextModels;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public bool DeleteFlag { get; set; }
}
