using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serivce.Abrstract
{
	public interface ICustomerAccountProcessService : IGenericService<CustomerAccountProcess>
	{

        List<CustomerAccountProcess> TMyLastProces(int id);
    }
}
