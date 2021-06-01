using System;
using System.Collections.Generic;
using System.Linq;
using Mappers;
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
            _userRepository.DeleteUserById(id);
        }

        public IQueryable<User> GetProjects()
        {
            foreach (UserEntity entity in _userRepository.GetAllUsers())
            {
                Users.Add(entity.ToDomain());
            }
            return Users.AsQueryable();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id).ToDomain();
        }

        public void UpdateUser(User model)
        {
            _userRepository.UpdateUser(model.ToEntity());
        }
    }
}
