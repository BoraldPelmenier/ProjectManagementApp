using Data.DbContexts;
using Data.Repositories.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repositories
{
    // CRUD repository.
    // может соединятся с бд, файлом, облаком и тд.
    // repos в единственном экземпляере и потокобезопасным.
    public class ProjectRepository : IProjectRepository
    {        
        private readonly ProjectContext _context;

        public ProjectRepository(ProjectContext context)
        {
            _context = context;
        }
        
        public void AddProject(ProjectEntity entity)
        {
            if (entity != null)
            {
                _context.Projects.Add(entity);
                _context.SaveChanges();
            }    
        }        

        public void DeleteProjectById(int id)
        {
            ProjectEntity entity = GetProjectById(id);
            if(entity != null)
            {
                _context.Projects.Remove(entity);
                _context.SaveChanges();
            }               
        }

        public IQueryable<ProjectEntity> GetProjects()
        {            
            return _context.Projects.OrderBy(x => x.Id);
        }

        public ProjectEntity GetProjectById(int? id)
        {
            return _context.Projects.Single(x => x.Id == id);
        }

        public void UpdateProject(ProjectEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
