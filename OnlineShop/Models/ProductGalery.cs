using System;
using System.Collections.Generic;

namespace OnlineShop.Models;

public partial class ProductGalery
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? ImageName { get; set; }
}
