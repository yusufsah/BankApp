﻿using Entity;
using Repository.Abstract;
using Serivce.Abrstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serivce
{
	public class CustomerAccountManager : ICustomerAccountService
	{
		private readonly ICustomerAccountDal _customerAccountDal;

		public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
		{
			_customerAccountDal = customerAccountDal;
		}

      

        public void TDelete(CustomerAccount t)
		{
			_customerAccountDal.Delete(t);
		}

		public CustomerAccount TGetByID(int id)
		{
		  return _customerAccountDal.GetByID(id);
		}

        public List<CustomerAccount> TGetCustomerAccountinformation(int id)
        {
			return _customerAccountDal.GetCustomerAccountinformation(id);
        }

        public List<CustomerAccount> TGetList()
		{
			return _customerAccountDal.GetList();
		}

		public void TInsert(CustomerAccount t)
		{
			_customerAccountDal.Insert(t);
		}

		public void TUpdate(CustomerAccount t)
		{
			_customerAccountDal.Update(t);
		}
	}
}
