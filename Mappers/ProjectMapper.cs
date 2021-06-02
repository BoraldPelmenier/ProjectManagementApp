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
                ProjectName = model.ProjectName,
                CompanyCustomer = model.CompanyCustomer,
                CompanyExecutor = model.CompanyExecutor,
                ProjectStart = model.ProjectStart,
                ProjectEnd = model.ProjectEnd,
                ProjectPriority = (int)model.ProjectPriority                
            };
        }

        public static Project ToDomain(this ProjectEntity entity)
        {            
            return new Project
            {
                Id = entity.Id,
                ProjectName = entity.ProjectName,
                CompanyCustomer = entity.CompanyCustomer,
                CompanyExecutor = entity.CompanyExecutor,
                ProjectStart = entity.ProjectStart,
                ProjectEnd = entity.ProjectEnd,
                ProjectPriority = (ProjectPriority)entity.ProjectPriority                
            };
        }
    }
}
