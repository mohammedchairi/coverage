using System.Data.Common;
using System.Security.Principal;

namespace DTO;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public int RoleId { get; set; }
    public Role? Role { get; set; }
    public List<Store> Stores { get; set; }
    public List<Cart> Carts { get; set; }
    public User(int userId, string userName, int roleId, Role? role, List<Store> stores, List<Cart> carts)
    {
        UserId = userId;
        UserName = userName;
        RoleId = roleId;
        Role = role;
        Stores = stores;
        Carts = carts;
    }

}
