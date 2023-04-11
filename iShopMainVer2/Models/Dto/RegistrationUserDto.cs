namespace iShopMain.Models.Dto
{
    public class RegistrationUserDto : IDto
    {
        public Guid Id { get; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}