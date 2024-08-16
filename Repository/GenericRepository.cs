using Repository.Abstract;
using Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class GenericRepository<T> : IGenericdal<T> where T : class
	{
		private readonly Context _context;

		public GenericRepository(Context context)
		{
			_context = context;
		}

		public void Delete(T t)
		{
			
			_context.Set<T>().Remove(t);
			_context.SaveChanges();

		}

		public T GetByID(int id)
		{

			return _context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			return _context.Set<T>().ToList();
		}

		public void Insert(T t)
		{
			_context.Set<T>().Add(t);
			_context.SaveChanges();
		}

		public void Update(T t)
		{
			_context.Update(t);
			_context.SaveChanges();	
		}
	}
}
