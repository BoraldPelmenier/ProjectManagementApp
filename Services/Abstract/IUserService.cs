using System.Linq;
using Domain;

namespace Services.Abstract
{
    public interface IUserService
    {
        void AddUser(User model);
        void UpdateUser(User model);
        IQueryable<User> GetUsers();
        User GetUserById(int? id);
        void DeleteUserById(int id);
    }
}
