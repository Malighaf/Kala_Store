using Bugeto_Store.Application.Services.Users.Commands.EditUser;
using Bugeto_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugeto_Store.Application.Services.Products.Commands.EditProduct
{
    public  interface  IEditProductService { 
        ResultDto Execute(RequestProductDto request);
}


public class RequestProductDto
    {
    public long UserId { get; set; }
    public string name { get; set; }
    public string brand { get; set; }
}
}
