using System.Collections.Generic;
using WorkshopWebApi.Models;

namespace WorkshopWebApi.Providers
{
    // CRUD
    public interface IUserProvider
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void AddUser(User user);
        void UpdateUser(int id, User user);
        void DeleteUser(int id);
    }
}