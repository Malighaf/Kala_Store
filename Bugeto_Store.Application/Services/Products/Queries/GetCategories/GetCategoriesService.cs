using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Application.Services.Products.Queries.GetProductForAdmin;
using Bugeto_Store.Common.Dto;
using Bugeto_Store.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bugeto_Store.Application.Services.Products.Queries.GetCategories
{
    public class GetCategoriesService : IGetCategoriesService
    {
        private readonly IDataBaseContext _context;

        public GetCategoriesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<CategoriesDtoForAdminDto> Execute(long? ParentId, int Page = 1, int PageSize = 20)
        {
            int rowCount = 0;

            var categories = _context.Categories
               .Include(p => p.ParentCategory)
               .Include(p => p.SubCategories)
               .Where(p => p.ParentCategoryId == ParentId)
               .ToList()
               .Select(p => new CategoriesDto
               {
                   Id = p.Id,
                   Name = p.Name,
                   Parent = p.ParentCategory != null ? new
                   ParentCategoryDto
                   {
                       Id = p.ParentCategory.Id,
                       name = p.ParentCategory.Name,
                   }
                   : null,
                   HasChild = p.SubCategories.Count() > 0 ? true : false,
               }).ToList();


            return new ResultDto<CategoriesDtoForAdminDto>()
            {
                Data = new CategoriesDtoForAdminDto()
                {
                    catdtt = categories,
                    CurrentPage = Page,
                    PageSize = PageSize,
                    RowCount = rowCount
                },
                IsSuccess = true,
                Message = "",
            };
        }
    }
    }



