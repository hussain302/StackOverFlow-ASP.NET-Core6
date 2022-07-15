using StackOverFlow.DataBase;
using StackOverFlow.DataBase.Users;
using StackOverFlow.Interfaces.RoleInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.DataAccess.UserRepositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly BlogContext context;

        public RoleRepository(BlogContext context)
        {
            this.context = context;
        }


        public IEnumerable<Role> GetAllRoles()
        {
            return context.Roles.ToList();
        }

        public Role GetRoleById(int RoleId)
        {
            return context.Roles.Where(x => x.Id == RoleId).FirstOrDefault();
        }

        public Role GetRoleByRoleName(string roleName)
        {
            return context.Roles.Where(x => x.Name == roleName).FirstOrDefault();
        }

        public void RemoveRole(int RoleId)
        {
            if(RoleId > 0)
            {
                context.Remove(GetRoleById(RoleId));
                context.SaveChanges();
            }
        }

        public void UpdateRole(Role Role)
        {
            if(Role != null)
            {
                context.Roles.Update(Role);
                context.SaveChanges();
            }
        }
    }
}
