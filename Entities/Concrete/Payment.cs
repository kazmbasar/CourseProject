using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Payment : BaseEntity<int>, IEntity
    {
        public int RoleId { get; set; }
        public float Price { get; set; }
        public DateTime PaymentHour { get; set; }
        public Role? Role { get; set; }

    }
}
