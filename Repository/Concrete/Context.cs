using Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
	public class Context : IdentityDbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True");
		}


		public DbSet<CustomerAccount> customerAccounts { get; set; }

		public DbSet<CustomerAccountProcess> customerAccountsProcess { get; set; }

	}
}
