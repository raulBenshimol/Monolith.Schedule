using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monolith.Schedule.Data
{
    public class MyTask
    {
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
