using StackOverFlow.DataBase.Users;
namespace StackOverFlow.Interfaces.UserInterfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public User GetUserById(int userId);
        public User GetUserByUserName(int userId);
        public User VerifyUser(User user);
        public void UpdateUser(User user);
        public void RemoveUser(int UserId);
        public void AddUser(User user);

    }
}
