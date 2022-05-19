using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface ITagRepository
    {
        public Task AddTag(TagModel tag);
        public Task DeleteTag(TagModel tag);
        public Task UpdateTag(TagModel tag);
        public Task<TagModel> GetTag(int tagId);
        public Task<List<TagModel>> GetAllTag();
    }
}
