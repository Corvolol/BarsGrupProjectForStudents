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

        public async Task AddReview(Review review,string userEmail)
        {
            if (review.User?.Email == userEmail)
            {
                _context.Reviews.Add(review);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteReview(Review review, string userEmail)
        {
            if (review.User?.Email == userEmail)
            {
                Review reviewToDelete = await GetReview(review.Id);
                _context.Reviews.Remove(reviewToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateReview(Review review, string userEmail)
        {
            if (review.User?.Email == userEmail)
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
