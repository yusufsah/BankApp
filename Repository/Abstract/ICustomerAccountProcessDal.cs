using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
	public interface ICustomerAccountProcessDal: IGenericdal<CustomerAccountProcess>
	{
		// bu sadece bunun için özel yazılan bir kod 

		List<CustomerAccountProcess> MyLastProces(int id);

	}
}
