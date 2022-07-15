
using StackOverFlow.DataBase.Users;


namespace StackOverFlow.Interfaces.RoleInterfaces
{
    public interface IRoleRepository
    {
        public IEnumerable<Role> GetAllRoles();
        public Role GetRoleById(int RoleId);
        public Role GetRoleByRoleName(string roleName);
        public void UpdateRole(Role Role);
        public void RemoveRole(int RoleId);
        public virtual void AddRole(Role Role) { }

    }
}
