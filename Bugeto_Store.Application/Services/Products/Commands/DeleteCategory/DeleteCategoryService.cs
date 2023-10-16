using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Application.Services.Products.Commands.AddNewCategory;
using Bugeto_Store.Application.Services.Users.Commands.RemoveUser;
using Bugeto_Store.Common.Dto;
using Bugeto_Store.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugeto_Store.Application.Services.Products.Commands.DeleteCategory
{
    public  class DeleteCategoryService : IDeleteCategoryService
    {
        private readonly IDataBaseContext _context;

        public DeleteCategoryService(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultDto Execute(long id )
        {

            var user = _context.Categories.Find(id);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }
            user.RemoveTime = DateTime.Now;
            user.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "کاربر با موفقیت حذف شد"
            };
        }
    }
}
