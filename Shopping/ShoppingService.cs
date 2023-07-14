using DTO;

namespace Shopping;

public class ShoppingService : IShoppingService
{
    public async Task<Cart> CreateCart(Cart cart)
    {
        // Here We need to add the business ... 
        //I will return true for the moment.
        return cart;
    }

    public async Task<bool> AddProductToCart(int cartId, int productId)
    {
        // Here We need to add the business ... 
        //I will return true for the moment.
        return true;
    }

    public Task<List<Cart>> GetCartsByOwner(int ownerId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Cart>> GetCartsByCustomer(int customerIn)
    {
        throw new NotImplementedException();
    }
}