using CMSPlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Services.Interfaces
{
    public interface ICommentService
    {
        public Task<CommentEntity> GetById(int id);

        public Task<IEnumerable<CommentEntity>> GetAll(int topicId);
        public Task Create(CommentEntity entity);
        public Task Update(CommentEntity entity);
        public Task Delete(int id);
    }
}
