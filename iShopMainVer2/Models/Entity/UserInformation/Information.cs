using System.ComponentModel.DataAnnotations;

namespace iShopMain.Models.Entity.UserInfo
{
    public class Information
    {
        [Key]
        public Guid Id { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; }
        public string Patronymic { get; set; } = string.Empty;
        public string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public DateOnly DateOfRegistration { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public Information()
        {
            Id = Guid.NewGuid();
        }
    }
}
