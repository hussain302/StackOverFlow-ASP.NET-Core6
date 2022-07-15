using StackOverFlow.DataBase.Blogs;
using StackOverFlow.DataBase.Users;
using StackOverFlow.Models.Blogs;

namespace StackOverFlow.Mappers
{
    public static class CategoryMapper
    {

        public static CategoryModel ConvertToWebModel(this Category source)
        {
            return new CategoryModel
            {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
            };
        }
        public static Category ConvertToDomainModel(this CategoryModel source)
        {
            return new Category
            {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
            };
        }
    }
}