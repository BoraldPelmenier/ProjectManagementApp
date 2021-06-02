using System.Linq;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IUserRepository
    {
        void AddUser(UserEntity user);
        void UpdateUser(UserEntity user);
        IQueryable<UserEntity> GetAllUsers();
        void DeleteUserById(int id);
        UserEntity GetUserById(int? id);
    }
}
