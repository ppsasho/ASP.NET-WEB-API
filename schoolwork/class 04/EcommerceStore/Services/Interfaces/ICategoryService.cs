using Data_Access.Implementations;
using Data_Access.Interfaces;
using DomainModels;
using DTOs.Category;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        public bool Add(CreateCategoryDto entity);
        public bool DeleteById(int id);
            
        public List<CategoryDto> GetAll();

        public Category GetById(int id);

        public bool Update(CreateCategoryDto entity);
    }
}
