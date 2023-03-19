using CMSPlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommentModels
{
    public class CommentModel
    {

        public string UserName { get; set; }
        public string Comment { get; set; }
        public int TopicId { get; set; }
    }
}
