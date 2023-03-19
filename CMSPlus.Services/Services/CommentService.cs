using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _repository;

        public CommentService(ICommentRepository repository)
        {
            _repository = repository;
        }
        public async Task Create(CommentEntity entity)
        {
             await _repository.Create(entity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<IEnumerable<CommentEntity>> GetAll(int topicId)
        {
            return await _repository.GetAll(topicId);
        }

        public async Task<CommentEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(CommentEntity entity)
        {
            await _repository.Update(entity);
        }
    }
}
