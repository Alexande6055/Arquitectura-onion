public class Product
{
    public int productid { get; set; }
    public string productname { get; set; } = string.Empty;
    public int? supplierid { get; set; }
    public int? categoryid { get; set; }
    public string? quantityperunit { get; set; }
    public decimal? unitprice { get; set; } = 0;
    public short? unitsinstock { get; set; } = 0;
    public short? unitsonorder { get; set; } = 0;
    public short? reorderlevel { get; set; } = 0;
    public bool discontinued { get; set; } = false;
}
