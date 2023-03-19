using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Entities
{
    public class CommentEntity:BaseEntity
    {
        public string UserName { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public int TopicId { get; set; } 

    }
}
