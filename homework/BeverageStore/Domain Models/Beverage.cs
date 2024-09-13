using Domain_Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain_Models
{
    public class Beverage : Base
    {
        public string Name { get; set; }
        public BeverageType Type { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
