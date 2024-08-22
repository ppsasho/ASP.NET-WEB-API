using Data_Access.Interfaces;
using DomainModels;
using DTOs.Category;
using Services.Interfaces;
using Services.Mappers;

namespace Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public bool Add(CreateCategoryDto entity) => entity != null && _repository.Add(entity.ToModel());

        public bool DeleteById(int id) => _repository.Any(id) && _repository.DeleteById(id);

        public List<CategoryDto> GetAll() => _repository.GetAll().Select(x => x.ToModel()).ToList();

        public Category GetById(int id) => _repository.GetById(id);

        public bool Update(CreateCategoryDto entity) => entity != null && _repository.Update(entity.ToModel());
    }
}
