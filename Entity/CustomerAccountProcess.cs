using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class CustomerAccountProcess
	{
        public int CustomerAccountProcessID { get; set; }

		public string ProcessType { get; set; }

		public decimal Amount { get; set; }

		public DateTime ProcessDate { get; set; }


		//
		public int? SenderID { get; set; }

		public int? ReveiverID { get; set; }

		// alt sınıf
		public CustomerAccount SenderCustomer { get; set; }

		public CustomerAccount ReveiverCustomer {  get; set; }

		public string Description { get; set; }



    }
}
