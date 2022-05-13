﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TagRepository: ITagRepository
    {
        private Context _context;
        public TagRepository(Context context)
        {
            _context = context;
        }

        public async Task AddTag(Tag tag)
        {
            await _context.Tags.AddAsync(tag);  
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTag(Tag tag)
        {
            Tag tagToDelete = await GetTag(tag.TagId);
            _context.Tags.Remove(tagToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTag(Tag tag)
        {
            Tag tagToUpdate = await GetTag(tag.TagId);
            _context.Tags.Update(tagToUpdate);
            await _context.SaveChangesAsync();
        }

        public async Task<Tag> GetTag(int tagId)
        {
            var tag = await _context.Tags.FirstOrDefaultAsync(x => x.TagId == tagId);
            return tag;
        }
    }
}

