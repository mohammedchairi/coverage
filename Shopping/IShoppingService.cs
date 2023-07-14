using DTO;

namespace Shopping;

public interface IShoppingService
{
    
    public Task<Cart> CreateCart(Cart cart);
    public Task<bool> AddProductToCart(int cartId, int productId);
    public Task<List<Cart>> GetCartsByOwner(int ownerId);
    public Task<List<Cart>>  GetCartsByCustomer(int customerIn);

}