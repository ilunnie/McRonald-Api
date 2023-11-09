using System;
using System.Collections.Generic;

namespace McRonald_Api.Model;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; }

    public byte[] Photo { get; set; }

    public string Description { get; set; }

    public virtual ICollection<ClientOrderItem> ClientOrderItems { get; set; } = new List<ClientOrderItem>();

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
