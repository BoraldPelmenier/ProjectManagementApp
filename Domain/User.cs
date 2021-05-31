
namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserSecondName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserEmail { get; set; }
        public UserStatus Status { get; set; }
        public int ProjectId { get; set; }
        public virtual Project ProjectModal { get; set; }
    }
}
