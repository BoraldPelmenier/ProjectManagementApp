using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Data.Repositories.Abstract;
using System.Text;
using Domain;
using Services.Abstract;

namespace Services
{
    public class UserService : IUserService
    {
        List<User> Users = new List<User>();
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void AddUser(User model)
        {
            _userRepository.AddUser(model.ToEntity());
        }

        public void DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetProjects()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User model)
        {
            throw new NotImplementedException();
        }
    }
}
