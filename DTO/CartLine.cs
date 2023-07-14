namespace DTO;

public class CartLine
{
    public CartLine(int cartLineId, int cartId, int productId, int quantity, Product? product, Cart? cart)
    {
        CartLineId = cartLineId;
        CartId = cartId;
        ProductId = productId;
        Quantity = quantity;
        CreationDate = DateTime.Now;
        Product = product;
        Cart = cart;
    }

    public int CartLineId { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime CreationDate { get; set; }

    public Product? Product { get; set; }
    public Cart? Cart { get; set; }

}