using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
	public interface ICustomerAccountDal:IGenericdal<CustomerAccount>
	{
		// giriş yapan kullanının hesap bilgilerini almak için 

		List<CustomerAccount> GetCustomerAccountinformation(int id);

	}
}
