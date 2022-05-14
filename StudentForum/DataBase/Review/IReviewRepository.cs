﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IReviewRepository
    {
        public Task AddReview(Review review, string userEmail);
        public Task DeleteReview(Review review, string userEmail);
        public Task UpdateReview(Review review, string userEmail);
        public Task<Review> GetReview(int reviewId);
    }
}
