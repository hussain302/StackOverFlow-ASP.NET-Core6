using StackOverFlow.DataBase.Users;
using StackOverFlow.Models.Users;

namespace StackOverFlow.Mappers
{
    public static class UserMapper
    {

        public static UserModel ConvertToWebModel(this User source)
        {
            return new UserModel
            {
                Id = source.Id,
                FullName = source.FullName,
                UserName = source.UserName,
                Address = source.Address,
                Email = source.Email,
                Role = source.Role.ConvertToWebModel(),
                Password = source.Password,
            };
        }
        public static User ConvertToDomainModel(this UserModel source)
        {
            return new User
            {
                Id = source.Id,
                FullName = source.FullName,
                UserName = source.UserName,
                Address = source.Address,
                Email = source.Email,
                RoleId = source.RoleId,
                Password = source.Password,
            };
        }

    }
}