using System.Collections.Generic;
using WorkshopWebApi.Models;
using System.Linq;

namespace WorkshopWebApi.Providers
{
    // CRUD
    public class InMemoryUserProvider : IUserProvider
    {
        List<User> users;
        public InMemoryUserProvider()
        {
            users = new List<User>()
            {
                new User() { Id = 0, Name = "Alex" },
                new User() { Id = 1, Name = "Andrei" },
                new User() { Id = 2, Name = "Lucian" },
                new User() { Id = 3, Name = "Marius" }
            };
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(int id)
        {
            users = users.Where(user => user.Id != id).ToList();
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }

        public void UpdateUser(int id, User user)
        {
            var userToBeUpdated = users.First(user => user.Id == id);
            userToBeUpdated.Name = user.Name;
        }
    }
}