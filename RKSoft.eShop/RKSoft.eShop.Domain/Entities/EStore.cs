namespace RKSoft.eShop.Domain.Entities
{
    public class EStore
    {
        public int Id { get; set; }
        public required string StoreName { get; set; }
        public required string Status { get; set; }
    }
}