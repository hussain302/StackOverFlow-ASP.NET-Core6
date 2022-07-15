using StackOverFlow.DataBase.Users;
using StackOverFlow.Models.Users;

namespace StackOverFlow.Mappers
{
    public static class RoleMapper
    {

        public static RoleModel ConvertToWebModel(this Role source)
        {
            return new RoleModel
            {
                Id = source.Id,
                Name = source.Name,
            };
        } 
        
        public static Role ConvertToDomainModel(this RoleModel source)
        {
            return new Role
            {
                Id = source.Id,
                Name = source.Name,
            };
        }
    }
}