using data_soruce_mil.daos;
using data_soruce_mil.models;

namespace data_soruce_mil.services
{
   public interface IUserService
    {
         User CreateOrUpdate(User user);
         User GetUserByCredentials(string username, string password);
        bool DeleteUser(User user);
    }

    public class UserService: IUserService
    {
        private UserDao _userDao;
        public UserService(UserDao dao)
        {
            _userDao = dao;
        }

        public User CreateOrUpdate(User user)
        {
            return _userDao.CreateOrUpdate(user:user);
        }

        public User GetUserByCredentials(string username, string password)
        {
           return _userDao.GetUserByCredentials(username: username, password: password);
        }

        public bool DeleteUser(User user)
        {
            return _userDao.DeleteUser(user: user);
        }
    }
}