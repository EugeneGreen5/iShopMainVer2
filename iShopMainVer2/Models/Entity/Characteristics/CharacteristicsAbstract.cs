namespace iShopMainVer2.Models.Entity.Characteristics
{
    public abstract class CharacteristicsAbstract
    {
        public Guid Id { get; set; }
        public CharacteristicsAbstract()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
