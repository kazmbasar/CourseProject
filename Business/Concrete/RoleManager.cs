using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public IResult Add(Role role)
        {
            _roleDal.Add(role);
            return new Result(true);
        }

        public IResult Delete(Role role)
        {
            _roleDal.Delete(role);
            return new Result(true);
        }

        public IDataResult<List<Role>> GetAll()
        {
           return new SuccessDataResult<List<Role>>(_roleDal.GetAll());
        }

        public IResult Update(Role role)
        {
            _roleDal.Update(role);
            return new Result(true);
        }
    }
}
