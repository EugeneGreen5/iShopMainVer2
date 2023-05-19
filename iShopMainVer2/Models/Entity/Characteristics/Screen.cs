namespace iShopMainVer2.Models.Entity.Characteristics
{
    public class Screen : BaseEntity
    {
        public int DiagonalScreen { get; set; }
        public string TypeScreen { get; set; }
        public string ResolutionScreen { get; set; }
        public int FrequencyScreen {  get; set; }
        public bool IsTouchScreen { get; set; }
    }
}
