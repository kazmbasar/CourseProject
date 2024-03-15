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
    public class LessonManager : ILessonService
    {
        private readonly ILessonDal _lessonDal;
        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }
        [ValidationAspect(typeof(LessonValidator))]
        public IResult Add(Lesson lesson)
        {
           _lessonDal.Add(lesson);
            return new Result(true);
        }

        public IResult Delete(Lesson lesson)
        {
           _lessonDal.Delete(lesson);
            return new Result(true);
        }

        public IDataResult<List<Lesson>> GetAll()
        {
            return new SuccessDataResult<List<Lesson>>(_lessonDal.GetAll());
        }

        public IResult Update(Lesson lesson)
        {
           _lessonDal.Update(lesson);
            return new Result(true);
        }
    }
}
