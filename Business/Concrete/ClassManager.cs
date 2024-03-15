using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ClassManager : IClassService
    {
        private readonly IClassDal _classDal;
        public ClassManager(IClassDal classDal)
        {
            _classDal = classDal;
            
        }
        [ValidationAspect(typeof(ClassValidator))]
        public IResult Add(Class _class)
        {
            _classDal.Add(_class);
            return new Result(true);
        }

        public IResult Delete(Class _class)
        {
           _classDal.Delete(_class);
            return new Result(true);
        }

        public IDataResult<List<Class>> GetAll()
        {
           return new SuccessDataResult<List<Class>>(_classDal.GetAll());
        }

        public IDataResult<List<Class>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<Class>>(_classDal.GetAll(c=> c.UserId==userId));
        }

        public IResult Update(Class _class)
        {
           _classDal.Update(_class);
            return new Result(true);
        }
    }
}
