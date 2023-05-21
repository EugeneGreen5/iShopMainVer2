namespace iShopMainVer2.Models.Dto
{
    public class AuthorizationUserDto : IDto
    {
        public Guid Id { get; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
