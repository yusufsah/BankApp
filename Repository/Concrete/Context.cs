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
	public class Context : IdentityDbContext<AppUser,AppRole,int>   //<> bunu migration oluştduktan sonra yaıyorsun unutma 
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=banka;Integrated Security=True");
		}


		public DbSet<CustomerAccount> customerAccounts { get; set; }

		public DbSet<CustomerAccountProcess> customerAccountsProcess { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerAccountProcess>()
				.HasOne(x=> x.SenderCustomer)
				.WithMany(y=> y.CustomerSender)
				.HasForeignKey(z => z.SenderID)
				.OnDelete(DeleteBehavior.ClientSetNull);

			builder.Entity<CustomerAccountProcess>()
				.HasOne(x => x.ReveiverCustomer)
				.WithMany(y => y.CustomerReceiver)
				.HasForeignKey(z => z.ReveiverID)
				.OnDelete(DeleteBehavior.ClientSetNull);

			base.OnModelCreating(builder);
        }

		

    }
}
