using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IReviewRepository
    {
        public Task AddReview(ReviewModel review);
        public Task DeleteReview(ReviewModel review);
        public Task UpdateReview(ReviewModel review);
        public Task<ReviewModel> GetReview(int reviewId);
    }
}
