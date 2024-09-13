using System.ComponentModel.DataAnnotations.Schema;

namespace Domain_Models
{
    public class Order : Base
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Beverage> Beverages { get; set; }
    }
}
