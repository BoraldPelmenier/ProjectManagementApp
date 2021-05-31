using Entities.Abstract;

namespace Entities
{
    public class UserEntity : BaseEntity
    {        
        public string UserFirstName { get; set; }
        public string UserSecondName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserEmail { get; set; }
        public int Status { get; set; }
        public int ProjectId { get; set; }
        public virtual ProjectEntity Entity { get; set; }
    }
}
