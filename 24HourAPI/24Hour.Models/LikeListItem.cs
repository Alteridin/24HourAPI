using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class LikeListItem
    {
        public Guid LikeIdz { get; set; }
        public int LikeId { get; set; }
        public Post LikedPost { get; set; }
        public User Liker { get; set; }
    }
}
