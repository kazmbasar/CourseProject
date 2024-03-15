using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ILessonService
    {
        IResult Add(Lesson lesson);
        IResult Delete(Lesson lesson);
        IResult Update(Lesson lesson);
        IDataResult<List<Lesson>> GetAll();
    }
    
}
