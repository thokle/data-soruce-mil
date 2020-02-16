using System;
using System.Runtime.Remoting.Messaging;
using data_soruce_mil.models;

namespace data_soruce_mil.daos
{
    public class UserDao
    {
        public  UserDao() {}

        public User CreateOrUpdate(User user)
        {
            return user;
        }
        
        
        public  User GetUserByCredentials(string  username, string password) {
           
        return new User();
        }

        public bool DeleteUser(User user)
        {
            return true;
        }

    }
}