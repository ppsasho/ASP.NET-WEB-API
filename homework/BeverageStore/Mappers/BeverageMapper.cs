using Domain_Models;
using Domain_Models.Enums;
using DTOs.Beverage;

namespace Mappers
{
    public static class BeverageMapper
    {
        public static Beverage ToModel(this CreateBeverageDto model)
        {
            BeverageType parsedType;
            if (Enum.TryParse(model.Type, out parsedType))
            {
                return new Beverage
                {
                    Name = model.Name,
                    Type = parsedType,
                    Quantity = model.Quantity,
                    Price = model.Price,
                };
            }
            else
            {
                return new Beverage { };
            }
        }
        public static BeverageDto ToModel(this Beverage model)
        {
            return new BeverageDto
            {
                Name = model.Name,
                Type = model.Type.ToString(),
                Quantity = model.Quantity,
                Price = model.Price
            };
        }
    }
}
