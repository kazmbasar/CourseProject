using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Lesson : BaseEntity<int>,IEntity
    { 
        public string? Name { get; set; }
        public float Price { get; set; }
        public ICollection<Class>? Classes { get; set; }
    }
}
