using Entity;
using Microsoft.EntityFrameworkCore;
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

        public List<CustomerAccountProcess> MyLastProces(int id)
        {
         using var context = new Context();

         var values = context.customerAccountsProcess
                
                .Include(y=>y.SenderCustomer).Include(w=>w.ReveiverCustomer)
                .ThenInclude(z=>z.AppUser).Where(x => x.ReveiverID == id || x.SenderID == id).ToList();

            // bunu yapmaya gerek yoktu  .Include(y=>y.SenderCustomer) ve .ThenInclude(z=>z.AppUser)
            
            // gerek olmayan kısım   isimleri getirmek için 
            //
            return values;
        }
    }
}
