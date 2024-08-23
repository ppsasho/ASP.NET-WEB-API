using DomainModels;
using DTOs.Category;

namespace Services.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDto ToModel(this Category category)
        {
            return new CategoryDto()
            {
                Name = category.Name,
            };
        }
        public static Category ToModel(this CreateCategoryDto category) 
        {
            return new Category()
            {
                Name = category.Name,
                Description = category.Description,
            };
        }
        public static Category ToModel(this CreateCategoryDto category, Category found) 
        {
            found.Name = category.Name;
            found.Description = category.Description;
            return found;
        }
    }
}
