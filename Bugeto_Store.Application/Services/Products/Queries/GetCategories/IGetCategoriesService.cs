using Bugeto_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bugeto_Store.Application.Services.Products.Queries.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<CategoriesDtoForAdminDto> Execute( long? ParentId, int Page = 1, int PageSize = 20);
    }
}



