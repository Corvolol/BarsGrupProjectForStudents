using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class ReviewRepository : IReviewRepository
    {
        private Context _context;
        public ReviewRepository(Context context)
        {
            _context = context;
        }

        public async Task AddReview(Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReview(Review review, User user)
        {
            if (review.User?.Email == user.Email)
            {
                Review reviewToDelete = await GetReview(review.Id);
                _context.Reviews.Remove(reviewToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateReview(Review review, User user)
        {
            if (review.User?.Email == user.Email)
            {
                Review reviewToUpdate = await GetReview(review.Id);
                _context.Reviews.Update(reviewToUpdate);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Review> GetReview(int reviewId)
        {
            var review = await _context.Reviews.FirstOrDefaultAsync(x => x.Id == reviewId);
            return review;
        }
    }
}
