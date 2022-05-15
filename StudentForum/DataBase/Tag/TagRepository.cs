using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TagRepository:ITagRepository
    {
        private Context _context;
        public TagRepository(Context context)
        {
            _context = context;
        }

        public async Task AddTag(TagModel tag)
        {
            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();
        }

       public async Task DeleteTag(TagModel tag)
        {
            TagModel tagToDelete = await GetTag(tag.TagId);
            _context.Tags.Remove(tagToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTag(TagModel tag)
        {
            TagModel tagToUpdate = await GetTag(tag.TagId);
            _context.Tags.Update(tagToUpdate);
            await _context.SaveChangesAsync();
        }

        public async Task<TagModel> GetTag(int tagId)
        {
            var tag = await _context.Tags.FirstOrDefaultAsync(x => x.TagId == tagId);
            return tag;
        }

        public async Task <List<TagModel>> GetAllTag()
        {
             var tag= await _context.Tags.ToListAsync();
            return tag;
        }

      
    }
}

