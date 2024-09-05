using Entity;
using Repository.Abstract;
using Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EfCustomerAccountProcess : GenericRepository<CustomerAccountProcess>, ICustomerAccountProcessDal
    {
        public EfCustomerAccountProcess(Context context) : base(context)
        {
        }
    }
}
