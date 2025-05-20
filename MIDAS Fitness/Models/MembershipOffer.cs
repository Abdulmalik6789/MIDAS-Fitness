namespace MIDAS_Fitness.Models
{
    public class MembershipOffer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public decimal SignupFee { get; set; }
        public decimal Tax { get; set; }
        public decimal FullCost { get; set; }
        public string Location { get; set; }
    }
}
