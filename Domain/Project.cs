using System; 
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string CompanyCustomer { get; set; }
        public string CompanyExecutor { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectEnd { get; set; }
        public ProjectPriority ProjectPriority { get; set; }
        public IQueryable<User> Users { get; set; }
    }
}
