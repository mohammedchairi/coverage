using DTO;
using Shopping;

namespace Test;

[TestClass]
public class ShoppingTest
{
    private readonly IShoppingService _shoppingService;
    public ShoppingTest(IShoppingService shoppingService)
    {
        _shoppingService = shoppingService;
    }
    [TestMethod]
    public void Get_CartByOwner_OK()
    {
        var cartId = 1;
        var userId = 1;
        var product1 = new Product(111, "T-Shirt", 1, 12.33);
        var product2 = new Product(222, "Jeans", 2, 90.10);

        var cartLines = new List<CartLine>()
        {
            new CartLine(1, product1.ProductId, cartId, 2, product1, null),
            new CartLine(1, product2.ProductId, cartId, 5, product2, null)
        };
            
        //act
        var cart = new Cart(cartId, userId, cartLines, null);

        //assert
        Assert.IsNotNull(cart);
        Assert.AreEqual(cart.TotalPrice,  cartLines.Sum(l => l.Product?.Price ?? 0));
    }
    
    [TestMethod]
    public async Task CreateCart_OK()
    {
        
        var cartId = 1;
        var userId = 1;
        //act
        var cart = new Cart(cartId, userId, new List<CartLine>(), null);
        var result = await _shoppingService.CreateCart(cart);
        //assert
        Assert.IsNotNull(cart);
        Assert.AreEqual(result.CartId, cart.CartId);
    }

    
    [TestMethod]
    public async Task AddProductToCart_OK()
    {
        
        var cartId = 1;
        var productId = 1;
        var result = await _shoppingService.AddProductToCart(cartId, productId);
        //assert
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public async Task GetCartsByOwner_OK()
    {
        var cartId = 1;
        var userId = 1;
        var cartLines = new List<CartLine>()
        {
            new CartLine(1, 4444, cartId, 22, null, null),
            new CartLine(1, 8888, cartId, 55, null, null)
        };

        var user = new User(1, "Owner", 1, null, new List<Store>() { new Store(1, "Store test", "Address", 1)}, new List<Cart>());
        var cart = new Cart(cartId, userId, cartLines, user);

        var ownerId = 1;
        var result = await _shoppingService.GetCartsByOwner(ownerId);
        //assert
        Assert.IsNotNull(result);
        Assert.AreEqual(result, cart.CartLines);
    }
    
}