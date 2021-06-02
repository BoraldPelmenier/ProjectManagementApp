using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Services.Abstract
{
    public interface IProjectService
    {
        void AddProject(Project model);
        void UpdateProject(Project model);
        IQueryable<Project> GetProjects();
        Project GetProjectById(int? id);
        void DeleteProjectById(int id);
    }
}
