using iShopMain.Models.Entity.UserInfo;

namespace iShopMain.Models.Dto
{
    public class RegistrationUserDto : IDto
    {
        public Guid Id { get; init; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public InformationEntity GetInformationUser() 
            => new()
            {
                Email = Email,
                Name = Name,
            };
    }
}