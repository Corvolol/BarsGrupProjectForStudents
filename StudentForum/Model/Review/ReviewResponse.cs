using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ReviewResponse
    {
        public int Id { get; set; }

        public string? review { get; set; }

        public DateTime date { get; set; }
    }
}
