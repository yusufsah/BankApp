using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
	public interface IGenericdal<T> where T : class
	{
		void Insert(T t);

		void Update(T t);

		void Delete(T t);


		T GetByID(int id);


		List<T> GetList();



	}
}
