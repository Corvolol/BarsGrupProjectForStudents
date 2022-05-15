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

        public async Task AddReview(ReviewModel review)
        {
                _context.Reviews.Add(review);
                await _context.SaveChangesAsync();
            
        }

        public async Task DeleteReview(ReviewModel review, string userEmail)
        {
            if (review.User?.Email == userEmail)
            {
                ReviewModel reviewToDelete = await GetReview(review.Id);
                _context.Reviews.Remove(reviewToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateReview(ReviewModel review, string userEmail)
        {
            if (review.User?.Email == userEmail)
            {
                ReviewModel reviewToUpdate = await GetReview(review.Id);
                _context.Reviews.Update(reviewToUpdate);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ReviewModel> GetReview(int reviewId)
        {
            var review = await _context.Reviews.FirstOrDefaultAsync(x => x.Id == reviewId);
            return review;
        }
    }
}
