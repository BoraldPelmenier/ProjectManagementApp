using Entities;
using System.Linq;

namespace Data.Repositories.Abstract
{
    public interface IProjectRepository
    {
        void AddProject(ProjectEntity proj);
        void UpdateProject(ProjectEntity proj);
        IQueryable<ProjectEntity> GetProjects();
        ProjectEntity GetProjectById(int? id);
        void DeleteProjectById(int id);

    }
}
