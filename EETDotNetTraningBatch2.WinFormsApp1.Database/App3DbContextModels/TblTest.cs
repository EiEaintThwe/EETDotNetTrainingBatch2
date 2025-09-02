using System;
using System.Collections.Generic;

namespace EETDotNetTraningBatch2.WinFormsApp1.Database.App3DbContextModels;

public partial class TblTest
{
    public int TestId { get; set; }

    public int TestCode { get; set; }

    public string TestName { get; set; } = null!;
}
