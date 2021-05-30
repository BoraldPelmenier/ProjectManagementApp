using Domain;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Mappers
{
    public static class ProjectMapper
    {
        public static ProjectEntity ToEntity(this Project model)
        {
            return new ProjectEntity
            {
                Id = model.Id,
                ProjectName = model.ProjName,
                Users = (IQueryable<UserEntity>)model.Users
            };
        }

        public static Project ToDomain(this ProjectEntity entity)
        {
            return new Project
            {
                Id = entity.Id,
                ProjName = entity.ProjectName,                
                //public UserEntity UserInfo { get; set; }
                //public UserEntity ProjectLeadInfo { get; set; }
                //public UserEntity ProjectExecutorInfo { get; set; }
                //public DateTime StartProj { get; set; }
                //public DateTime EndProj { get; set; }
                //public int ProjPriority { get; set; }
                Users = (IQueryable<User>)entity.Users
            };
        }
    }
}
