using Data.DbContexts;
using Data.Repositories.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    // CRUD repository.
    // может соединятся с бд, файлом, облаком и тд.
    // repos в единственном экземпляере и потокобезопасным.
    public class ProjectRepository : IProjectRepository
    {
        //private static List<ProjectEntity> _list = new List<ProjectEntity>();
        private readonly ProjectContext _context;

        public ProjectRepository(ProjectContext context)
        {
            _context = context;
        }
        
        public void AddProject(ProjectEntity proj)
        {
            if (proj != null)
            {
                _context.Projects.Add(proj);
                _context.SaveChanges();
            }
               

        }        

        public void DeleteProjectById(int id)
        {
            ProjectEntity proj = GetProjectById(id);
            if(proj != null)
            {
                _context.Projects.Remove(proj);
                _context.SaveChanges();
            }
                
        }

        public IQueryable<ProjectEntity> GetProjects()
        {            
            return _context.Projects.OrderBy(x => x.Id);
        }

        public ProjectEntity GetProjectById(int id)
        {
            return _context.Projects.Single(x => x.Id == id);
        }

        public void UpdateProject(ProjectEntity proj)
        {
            throw new System.NotImplementedException();
        }
    }
}
