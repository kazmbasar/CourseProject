using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Role : BaseEntity<int>, IEntity
    {
        public string? Name { get; set; }
    }
}
