namespace EcommerceStoreAPI.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 1;
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        public int ModiefiedBy { get; set; } = 1;
    }
}
