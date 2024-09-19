using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class TblUser
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public string? NickName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public Status? Status { get; set; }

    public Role? Role { get; set; }

    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();
}
