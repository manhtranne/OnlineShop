using System;
using System.Collections.Generic;

namespace OnlineShop.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Desciption { get; set; }

    public string? FullDesc { get; set; }

    public decimal? Price { get; set; }

    public decimal? Disscount { get; set; }

    public string? ImageName { get; set; }

    public int? Qty { get; set; }

    public string? Tags { get; set; }

    public string? VideoUrl { get; set; }
}
