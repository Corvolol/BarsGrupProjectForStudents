using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ReviewRequest
    {
        public string? review { get; set; }

        public int teacherId { get; set; }
    }
}
