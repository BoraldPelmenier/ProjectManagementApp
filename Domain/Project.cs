using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjName { get; set; }
        //public string CustomerCompanyName { get; set; }
        //public string ExecutorCompanyName { get; set; }
        //public UserEntity UserInfo { get; set; }
        //public UserEntity ProjectLeadInfo { get; set; }
        //public UserEntity ProjectExecutorInfo { get; set; }
        //public DateTime StartProj { get; set; }
        //public DateTime EndProj { get; set; }
        //public int ProjPriority { get; set; }
        public IQueryable<User> Users { get; set; }
    }
}
