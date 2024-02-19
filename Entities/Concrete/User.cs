using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class User : BaseEntity<int>,IEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int RoleId { get; set; }
    }
}