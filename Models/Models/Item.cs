using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Item
{
    public string ItemId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public decimal ItemPrice { get; set; }

    public int ItemQuantity { get; set; }

    public string OrderId { get; set; } = null!;

    public virtual TblOrder Order { get; set; } = null!;
}
