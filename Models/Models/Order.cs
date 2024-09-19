using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public decimal TotalPrice { get; set; }

    public int ItemQuantity { get; set; }

    public string UserId { get; set; } = null!;

    public virtual ICollection<Item> TblItems { get; set; } = new List<Item>();

    public virtual User User { get; set; } = null!;
}
