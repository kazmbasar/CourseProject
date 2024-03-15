using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IClassService
    {
        IResult Add(Class _class);
        IResult Delete(Class _class);
        IResult Update(Class _class);
        IDataResult<List<Class>> GetAll();
        IDataResult<List<Class>> GetAllByUserId(int userId);
    }
}
