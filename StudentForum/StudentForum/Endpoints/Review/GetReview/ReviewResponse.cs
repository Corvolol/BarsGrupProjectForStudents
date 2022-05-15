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
        public string? Value { get; set; }
        public DateTime Date { get; set; }
    }
}
