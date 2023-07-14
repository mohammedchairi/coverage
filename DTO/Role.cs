namespace DTO;

public class Role
{
    public Role(int roleId, string name)
    {
        RoleId = roleId;
        Name = name;
    }

    public int RoleId { get; set; }
    public string Name { get; set; }
}