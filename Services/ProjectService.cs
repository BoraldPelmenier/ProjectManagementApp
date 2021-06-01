using Domain;
using Services.Abstract;
using Data.Repositories.Abstract;
using Mappers;
using Entities;
using System.Linq;
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
        public void AddProject(Project model)
        {
            _projectRepository.AddProject(model.ToEntity());
        }

        public void DeleteProjectById(int id)
        {
            _projectRepository.DeleteProjectById(id);
        }

        public IQueryable<Project> GetProjects()
        {              
            foreach(ProjectEntity entity in _projectRepository.GetProjects())
            {    
                Projects.Add(entity.ToDomain());
            }
            return Projects.AsQueryable();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetProjectById(id).ToDomain();          
        }

        public void UpdateProject(Project model)
        {
            _projectRepository.UpdateProject(model.ToEntity());
        }
    }
}
