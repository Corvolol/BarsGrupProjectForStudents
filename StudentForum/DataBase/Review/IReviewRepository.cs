using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IReviewRepository
    {
        public Task AddReview(Review review);
        public Task DeleteReview(Review review);
        public Task UpdateReview(Review review);
        public Task<Review> GetReview(int reviewId);
    }
}
