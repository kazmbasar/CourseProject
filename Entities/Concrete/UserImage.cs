using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete
{
    public class UserImage:BaseEntity<int>,IEntity
    {
        public int UserId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date {  get; set; }
        [ForeignKey("UserId")]
        public User? user { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
