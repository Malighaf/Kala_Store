using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Application.Services.Products.Commands.RemovePrduct;
using Bugeto_Store.Application.Services.Users.Commands.RemoveUser;
using Bugeto_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugeto_Store.Application.Services.Products.Commands.RemoveUser
{
    internal class RemoveProductService : IRemoveProductService
    {
        private readonly IDataBaseContext _context;

        public RemoveProductService(IDataBaseContext context)
        {
            _context = context;
        }


        public ResultDto Execute(long UserId)
        {

            var user = _context.Products.Find(UserId);
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
