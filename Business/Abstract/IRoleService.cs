using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRoleService
    {
        IResult Add(Role role);
        IResult Delete(Role role);
        IResult Update(Role role);
        IDataResult<List<Role>> GetAll();
    }
}
