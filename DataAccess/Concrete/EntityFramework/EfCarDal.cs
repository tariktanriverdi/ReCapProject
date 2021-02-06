using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
public	class EfCarDal : ICarDal
	{
		public void Add(Car entity)
		{   
			using(MyDBContext context=new MyDBContext())
			{
				var addedCar = context.Entry(entity);
				addedCar.State = EntityState.Added;
				context.SaveChanges();
			}
			Console.WriteLine("added");
		}

		public void Delete(Car entity)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			using (MyDBContext context = new MyDBContext())
			{
				return filter == null
					? context.Set<Car>().ToList()
					: context.Set<Car>().Where(filter).ToList();
			}
		}

		public Car GetById(Expression<Func<Car, bool>> filter )
		{
			using (MyDBContext context = new MyDBContext())
			{
				return context.Set<Car>().SingleOrDefault(filter);
			}
		}

		public void Update(Car entity)
		{
			throw new NotImplementedException();
		}
	}
}
