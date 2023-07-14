namespace DTO;

public class Store
{
    public int StoreId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int OwnerId { get; set; }
    public User? Owner { get; set; }
    
    public Store(int storeId, string name, string address, int ownerId, User? owner = null)
    {
        StoreId = storeId;
        Name = name;
        Address = address;
        OwnerId = ownerId;
        Owner = owner;
    }
    
}