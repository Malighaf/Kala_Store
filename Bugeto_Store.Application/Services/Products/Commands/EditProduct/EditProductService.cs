using Bugeto_Store.Application.Interfaces.Contexts;
using Bugeto_Store.Common.Dto;

namespace Bugeto_Store.Application.Services.Products.Commands.EditProduct
{
    public class EditProductService : IEditProductService
    {
    private readonly IDataBaseContext _context;

    public EditProductService(IDataBaseContext context)
    {
        _context = context;
    }
    public ResultDto Execute(RequestProductDto request)
    {
        var user = _context.Products.Find(request.UserId);
        if (user == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "کاربر یافت نشد"
            };
        }

        user.Name = request.name;
        user.Brand = request.brand;
        _context.SaveChanges();

        return new ResultDto()
        {
            IsSuccess = true,
            Message = "ویرایش کاربر انجام شد"
        };

    }
}
}
