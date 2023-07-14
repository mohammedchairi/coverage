using System.Data.Common;

namespace DTO;

public class Cart
{
    public int CartId { get; set; }
    public int UserId { get; set; }
    public double TotalPrice { get; set; }
    public DateTime CreationDate { get; set; }

    public User? User { get; set; }
    public List<CartLine> CartLines { get; set; }

    public Cart(int cartId, int userId, List<CartLine> cartLines, User? user)
    {
        CartId = cartId;
        UserId = userId;
        CartLines = cartLines;
        TotalPrice = cartLines.Sum(l => l.Product?.Price ?? 0);
        CreationDate = DateTime.Now;
        User = user;
    }
}



