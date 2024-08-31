using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class CustomerAccount
	{
        public int CustomerAccountID { get; set; }
		public string CustomerAccountNubmer { get; set; } 

		public string Currency { get; set; } 

		public decimal accountbalance { get; set; }      
		
		public string BankBranch { get; set; }

		// üst sınıf
		public int AppUserID { get; set; }

		public AppUser AppUser { get; set; }

		//
	    public List<CustomerAccountProcess> CustomerSender  { get; set; }

        public List<CustomerAccountProcess> CustomerReceiver { get; set; }


    }
}
