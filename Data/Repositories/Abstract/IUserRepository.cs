using System.Collections.Generic;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IUserRepository
    {
        void AddUser(UserEntity user);
        void UpdateUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        void DeleteUserById(int id);
    }
}
