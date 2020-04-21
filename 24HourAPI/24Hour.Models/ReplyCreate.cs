using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class ReplyCreate
    {
        public int ReplyId { get; set; }
        [Required]
        public Comment ReplyComment { get; set; }
        [Required]
        public string ReplyText { get; set; }
    }
}
