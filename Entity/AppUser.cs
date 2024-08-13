using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class AppUser : IdentityUser<int>
	{

		public string Name { get; set; }

		public string Surname { get; set; }

		public string District { get; set; }

		public string City { get; set; }

		public string ImageUrl { get; set; }

		// alt sınıf
		public List<CustomerAccount> customerAccounts { get; set; }

	}
}
