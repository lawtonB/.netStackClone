using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackClone.Models
{
    [Table("Posts")]
    public class Post
    {
        public int id { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
