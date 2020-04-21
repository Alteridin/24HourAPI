using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class LikeCreate
    {
        public Guid LikeIdz { get; set; }
        public int LikeId { get; set; }
        [Required]
        public Post LikedPost { get; set; }
    }
}
