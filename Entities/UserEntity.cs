using Entities.Abstract;

namespace Entities
{
    public class UserEntity : BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSecondName { get; set; }
        //public string UserEmail { get; set; }
        //public int UserPosition { get; set; }
        public int ProjectId { get; set; }
        public virtual ProjectEntity Entity { get; set; }
    }
}
