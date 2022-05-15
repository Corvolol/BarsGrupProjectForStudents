using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface ITagRepository
    {
        public Task AddTag(Tag tag);
        public Task DeleteTag(Tag tag);
        public Task UpdateTag(Tag tag);
        public Task<Tag> GetTag(int tagId);
        public Task<List<Tag>> GetAllTag();
    }
}
