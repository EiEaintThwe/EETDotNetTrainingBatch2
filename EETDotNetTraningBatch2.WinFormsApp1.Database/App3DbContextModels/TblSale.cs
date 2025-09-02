using System;
using System.Collections.Generic;

namespace EETDotNetTraningBatch2.WinFormsApp1.Database.App3DbContextModels;

public partial class TblSale
{
    public int SaleId { get; set; }

    public string VoucherNo { get; set; } = null!;

    public DateTime SaleDate { get; set; }

    public decimal TotalAmount { get; set; }

    public bool DeleteFlag { get; set; }
}
