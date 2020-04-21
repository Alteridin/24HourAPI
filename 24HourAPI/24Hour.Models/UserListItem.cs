using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
	public class UserListItem
	{
		public Guid UserId { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }
	}

}
