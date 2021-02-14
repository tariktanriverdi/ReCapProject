using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
public	class CarDetailDto:IDto
	{
		public int Id { get; set; }
		public string BrandName { get; set; }
		public DateTime ModelYear { get; set; }
		public double DailyPrice { get; set; }
		public string Description { get; set; }
	}
}
