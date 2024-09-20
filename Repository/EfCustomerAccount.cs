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
    public class EfCustomerAccount : GenericRepository<CustomerAccount>, ICustomerAccountDal
    {
        public EfCustomerAccount(Context context) : base(context)
        {
        }

        public List<CustomerAccount> GetCustomerAccountinformation(int id)
        {
            using var context = new Context();  
            var values = context.customerAccounts.Where(x=>x.AppUserID==id ).ToList();

            return values;

        }
    }
}
