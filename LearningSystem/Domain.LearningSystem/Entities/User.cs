
namespace Domain.LearningSystem.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int Role { get; set; }
        public string Surname { get; set; } = String.Empty;
        public string PasswordHash {  get; set; } = String.Empty;
        public string PasswordSalt { get; set; } = String.Empty;
    }
}
