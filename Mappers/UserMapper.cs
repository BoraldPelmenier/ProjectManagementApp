using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Entities;

namespace Mappers
{
    public static class UserMapper
    {
        public static UserEntity ToEntity (this User model)
        {
            return new UserEntity
            {
                Id = model.Id,
                UserFirstName = model.UserFirstName,
                UserSecondName = model.UserSecondName,
                UserMiddleName = model.UserMiddleName,
                UserEmail = model.UserEmail,
                Status = (int)model.Status,
                ProjectId = model.ProjectId,
                CreatedDate = model.CreatedDate
            };
        }

        public static User ToEntity(this UserEntity entity)
        {
            return new User
            {
                Id = entity.Id,
                UserFirstName = entity.UserFirstName,
                UserSecondName = entity.UserSecondName,
                UserMiddleName = entity.UserMiddleName,
                UserEmail = entity.UserEmail,
                Status = (UserStatus)entity.Status,
                ProjectId = entity.ProjectId,
                CreatedDate = entity.CreatedDate
            };
        }
    }
}
