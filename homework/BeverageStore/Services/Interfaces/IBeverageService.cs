using Domain_Models;
using Domain_Models.Enums;
using DTOs.Beverage;

namespace Services.Interfaces
{
    public interface IBeverageService
    {
        public List<BeverageDto> GetAll();
        public BeverageDto GetById(int id);
        public bool Any(int id);
        public bool Add(BeverageCreateDto entity);
        public bool Update(BeverageCreateDto entity, int id);
        public bool Delete(int id);

        public List<BeverageDto> FilterByName(string name);
        public List<BeverageDto> FilterByType(BeverageType type);
        public List<BeverageDto> FilterByNameAndType(string name, BeverageType type);
    }
}
