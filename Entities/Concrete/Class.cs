using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Class : BaseEntity<int>, IEntity
    {
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public Lesson? Lesson { get; set; }
        public User? User { get; set; }

    }
}
