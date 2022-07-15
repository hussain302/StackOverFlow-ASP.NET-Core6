using StackOverFlow.DataBase;
using StackOverFlow.DataBase.Users;
using StackOverFlow.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.DataAccess.UserRepositories
{
    public class UserRepository : IUserRepository
    {

        private readonly BlogContext context;

        public UserRepository(BlogContext context)
        {
            this.context = context;
        }

        public void AddUser(User user)
        {
            if (user != null)
            {
                context.Add(user);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.User.ToList();
        }

        public User GetUserById(int userId)
        {
            var find = context.User.Where(x => x.Id == userId).FirstOrDefault();
            return find;
        }

        public User GetUserByUserName(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int UserId)
        {
            context.Remove(GetUserById(UserId));
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            if (user != null)
            {
                context.Update(user);
                context.SaveChanges();
            }
        }

        public User VerifyUser(User user)
        {
            if (user != null)
            {
#pragma warning disable CS8603 // Possible null reference return.
                var find = context.User
                    .Where(x => x.UserName == user.UserName)
                    .Where(x => x.Password == user.Password)
                    .FirstOrDefault();
                return find;
            }
            else
            {
                return null;
            }
        }
    }
}
