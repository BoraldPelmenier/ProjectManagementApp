using Domain;
using Services.Abstract;
using Data.Repositories.Abstract;
using Mappers;
using Entities;
using System.Linq;
using Data.Repositories;
using System.Collections.Generic;

namespace Services
{
    public class ProjectService : IProjectService
    {  
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public void AddProject(Project proj)
        {
            _projectRepository.AddProject(proj.ToEntity());
        }

        public void DeleteProjectById(int id)
        {
            _projectRepository.DeleteProjectById(id);
        }

        public IQueryable<Project> GetProjects()
        {
            List<Project> Projects = new List<Project>();
            foreach(ProjectEntity proj in _projectRepository.GetProjects())
            {                
                Projects.Append(proj.ToDomain());
            }
            return Projects.AsQueryable();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetProjectById(id).ToDomain();          
        }

        public void UpdateProject(Project proj)
        {
            _projectRepository.UpdateProject(proj.ToEntity());
        }
    }
}
