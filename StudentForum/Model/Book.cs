using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Book
    {

        [Key] public int Id { get; set; }
        public string? Value { get; set; }
        public TagModel? Tag { get; set; }

    }
}
