namespace DTO;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int ProductTypeId { get; set; }
    public double Price { get; set; }
    public ProductType? ProductType { get; set; }
    
    public Product(int productId, string name, int productTypeId, double price, ProductType? productType = null)
    {
        ProductId = productId;
        Name = name;
        ProductTypeId = productTypeId;
        Price = price;
        ProductType = productType;
    }
}

