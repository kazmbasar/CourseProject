using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Role : BaseEntity<int>, IEntity
    {
        public string? Name { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}
