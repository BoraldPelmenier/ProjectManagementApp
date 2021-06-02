using System.Linq;
using Domain;

namespace WebApi.ViewModels
{
    public class InfoViewModel
    {
        public Project ProjectModel { get; set; }
        public IQueryable<User> Users { get; set; }
    }
}
