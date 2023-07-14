namespace DTO;

public class ProductType
{
    public ProductType(int productTypeId, string name)
    {
        ProductTypeId = productTypeId;
        Name = name;
    }

    public int ProductTypeId { get; set; }
    public string Name { get; set; }
}