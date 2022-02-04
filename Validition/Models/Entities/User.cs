using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validition.Models.Entities
{
    public class User
    {
        public long ID { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="ایمیل نا معتبر می باشد")]
        public string Email { get; set; }

        [Range(16,60)]
        public int Age { get; set; }
    }
}
