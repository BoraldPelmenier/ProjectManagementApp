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
        private List<Project> Projects = new List<Project>();

        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public void AddProject(Project project)
        {
            _projectRepository.AddProject(project.ToEntity());
        }

        public void DeleteProjectById(int id)
        {
            _projectRepository.DeleteProjectById(id);
        }

        public IQueryable<Project> GetProjects()
        {              
            foreach(ProjectEntity project in _projectRepository.GetProjects())
            {                
                Projects.Append(project.ToDomain());
            }
            return Projects.AsQueryable();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetProjectById(id).ToDomain();          
        }

        public void UpdateProject(Project project)
        {
            _projectRepository.UpdateProject(project.ToEntity());
        }
    }
}
