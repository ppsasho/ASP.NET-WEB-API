using Data_Access.Interfaces;
using Domain_Models.Enums;
using DTOs.Beverage;
using Mappers;
using Services.Interfaces;

namespace Services.Implementations
{
    public class BeverageService : IBeverageService
    {
        private IBeverageRepository _repository;
        public BeverageService(IBeverageRepository repo)
        {
            _repository = repo;
        }
        public bool Add(BeverageCreateDto entity)
        {
            if (_repository.Any(entity.Name))
                return false;

            return _repository.Add(entity.ToModel());
        }

        public bool Any(int id) => _repository.Any(id);

        public bool Delete(int id)
        {
            if (!_repository.Any(id)) return false;

            return _repository.Delete(id);
        }

        public List<BeverageDto> FilterByName(string name) =>
            _repository.GetAll().Where(x => x.Name.ToLower().Contains(name.ToLower()))
                                   .Select(x => x.ToModel())
                                   .ToList();
        public List<BeverageDto> FilterByNameAndType(string name, BeverageType type) =>
            _repository.GetAll().Where(x => x.Type == type
                                         && x.Name.ToLower().Contains(name.ToLower()))
                                .Select(x => x.ToModel())
                                .ToList();

        public List<BeverageDto> FilterByType(BeverageType type) =>
            _repository.GetAll().Where(x => x.Type == type)
                                .Select(x => x.ToModel())
                                .ToList();

        public List<BeverageDto> GetAll() => _repository.GetAll().Select(x => x.ToModel()).ToList();

        public BeverageDto GetById(int id) {
            var found = _repository.GetById(id);

            if (found != null) return found.ToModel();

            return new BeverageDto();
        }

        public bool Update(BeverageCreateDto entity, int id)
        {
            var found = _repository.GetById(id);
            if (found != null) 
            {
                BeverageType parsed;
                if(Enum.TryParse(entity.Type, out parsed)){
                    found.Name = entity.Name;
                    found.Type = parsed;
                    found.Price = entity.Price;
                    found.Quantity = entity.Quantity;
                    return _repository.Update(found);
                }
                return false;
            }
            return false;
        }
    }
}
