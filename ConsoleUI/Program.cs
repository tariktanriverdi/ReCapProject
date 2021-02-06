using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new EfCarDal());
			Car newCar = new Car {Id=1, DailyPrice = 15.30, Description = "This is new car", BrandId = 10, ModelYear = new DateTime(1990, 07, 01) };
			//carManager.Add(newCar);
			carManager.GetAll().ForEach(f => Console.WriteLine(f.Description));
			Console.WriteLine(carManager.GetById(x => x.Id.Equals(1)).Description);
		}
	}
}
