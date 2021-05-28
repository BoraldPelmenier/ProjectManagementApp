using Domain;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Mappers
{
    public static class ProjectMapper
    {
        public static ProjectEntity ToEntity(this Project proj)
        {
            return new ProjectEntity
            {
                Id = proj.Id,
                ProjectName = proj.ProjName,
                Users = (IQueryable<UserEntity>)proj.Users
            };
        }

        public static Project ToDomain(this ProjectEntity proj)
        {
            return new Project
            {
                Id = proj.Id,
                ProjName = proj.ProjectName,                
                //public UserEntity UserInfo { get; set; }
                //public UserEntity ProjectLeadInfo { get; set; }
                //public UserEntity ProjectExecutorInfo { get; set; }
                //public DateTime StartProj { get; set; }
                //public DateTime EndProj { get; set; }
                //public int ProjPriority { get; set; }
                Users = (IQueryable<User>)proj.Users
            };
        }
    }
}
