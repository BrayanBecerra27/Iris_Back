using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisCore.Entities
{
    public class ToDo
    { 

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsCompleted { get; set; }
    }
}
