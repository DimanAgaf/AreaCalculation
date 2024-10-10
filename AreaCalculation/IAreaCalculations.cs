using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
	public interface IAreaCalculations
	{
		/// <summary>
		/// площадь круга по радиусу
		/// </summary>
		/// <param name="r">радиус</param>
		/// <returns></returns>
		public double GetCircleArea(double r);
		/// <summary>
		/// площадь треугольника по трем сторонам
		/// </summary>
		/// <param name="a">сторона a (катет)</param>
		/// <param name="b">сторона b (катет)</param>
		/// <param name="c">сторона с (гипотенуза)</param>
		/// <returns></returns>
		public double GetTriangleArea(double a, double b, double c);
	}
}
