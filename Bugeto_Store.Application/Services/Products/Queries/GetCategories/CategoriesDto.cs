using Bugeto_Store.Application.Services.Products.Queries.GetProductForAdmin;
using System.Collections.Generic;

namespace Bugeto_Store.Application.Services.Products.Queries.GetCategories
{
    public class CategoriesDto
    {
        
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public ParentCategoryDto Parent { get; set; }

    }
    public class CategoriesDtoForAdminDto
    {
        public int RowCount { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public List<CategoriesDto> catdtt { get; set; }
    }
}



