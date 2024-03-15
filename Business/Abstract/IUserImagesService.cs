using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IUserImagesService
    {
        IResult Add(IFormFile file,UserImage userImage);
        IResult Delete(UserImage userImage);
        IResult Update(IFormFile file,UserImage userImage);
    }
}
