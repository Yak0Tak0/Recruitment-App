using System;
using System.Collections.Generic;

namespace RecruitmentApp;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public int ProductPrice { get; set; }

    public string ProductCategory { get; set; } = null!;

    public DateTime AddDate { get; set; }

    public DateTime EditDate { get; set; }

    public DateTime DeleteDate { get; set; }
}
