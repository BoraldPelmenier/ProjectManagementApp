using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Services.Abstract
{
    public interface IProjectService
    {
        void AddProject(Project proj);
        void UpdateProject(Project proj);
        IQueryable<Project> GetProjects();
        Project GetProjectById(int id);
        void DeleteProjectById(int id);
    }
}
