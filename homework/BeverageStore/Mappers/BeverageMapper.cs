using Domain_Models;
using Domain_Models.Enums;
using DTOs.Beverage;

namespace Mappers
{
    public static class BeverageMapper
    {
        public static Beverage ToModel(this BeverageCreateDto model)
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
            var BeverageDto = new BeverageDto();
            if (model != null)
            {
                BeverageDto.Name = model.Name;
                BeverageDto.Type = model.Type.ToString();
                BeverageDto.Quantity = model.Quantity;
                BeverageDto.Price = model.Price;
            }
            return BeverageDto;
        }
    }
}
