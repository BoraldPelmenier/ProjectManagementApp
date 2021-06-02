using Data.Repositories.Abstract;
using Entities;
using Data.DbContexts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectContext _userContext;
        public UserRepository(ProjectContext userContext)
        {
            _userContext = userContext;
        }
        public void AddUser(UserEntity entity)
        {
            _userContext.Add(entity);
            _userContext.SaveChanges();
        }

        public void DeleteUserById(int id)
        {
            UserEntity entity = GetUserById(id);
            if(entity != null)
            {            
                _userContext.Remove(entity);
                _userContext.SaveChanges();
            }
        }

        public IQueryable<UserEntity> GetAllUsers()
        {
            return _userContext.Users.OrderBy(u => u.Id);
        }

        public void UpdateUser(UserEntity entity)
        {
            _userContext.Entry(entity).State = EntityState.Modified;
            _userContext.SaveChanges();
        }

        public UserEntity GetUserById(int? id)
        {
            return _userContext.Users.Single(u => u.Id == id);
        }
    }
}
