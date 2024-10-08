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
	public class CustomerAccountProcessManager : ICustomerAccountProcessService
	{

		private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

		public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
		{
			_customerAccountProcessDal = customerAccountProcessDal;
		}

		public void TDelete(CustomerAccountProcess t)
		{
			_customerAccountProcessDal.Delete(t);	
		}

		public CustomerAccountProcess TGetByID(int id)
		{
			return _customerAccountProcessDal.GetByID(id);
		}

		public List<CustomerAccountProcess> TGetList()
		{
			return _customerAccountProcessDal.GetList();
		}

		public void TInsert(CustomerAccountProcess t)
		{
			_customerAccountProcessDal.Insert(t);
		}


        // BU AYRI OLUŞTURDUM DEĞİERLERİNDEN SON İŞLEMLERİ GETİREBİLEMEK İÇİN 
        public List<CustomerAccountProcess> TMyLastProces(int id)
        {
            return _customerAccountProcessDal.MyLastProces(id);
        }

        public void TUpdate(CustomerAccountProcess t)
		{
			_customerAccountProcessDal.Update(t);
		}


		
       
    }
}
