using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Class : BaseEntity<int>, IEntity
    {
        public int LessonId { get; set; }
        public int RoleId { get; set; }
    }
}
