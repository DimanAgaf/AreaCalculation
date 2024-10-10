namespace AreaCalculation
{
	public class AreaCalculations : IAreaCalculations
	{
		// число pi как сонстанта задаетсят вручную
		const double pi = Math.PI;
		public double GetCircleArea(double r)
		{
			double S = pi * Math.Pow(r, 2);
			return Math.Round(S, 2);
		}

		public double GetTriangleArea(double a, double b, double c)
		{
			if (PT(a, b, c))
			{
				double S = a * b / 2;
				return Math.Round(S, 2);
			}
			else
			{
				double p = (a + b + c) / 2;
				double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
				return Math.Round(S, 2);
			}
		}

		//PythagoreanTheorem
		private bool PT(double a, double b, double c)
		{
			if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
				return true;
			else
				return false;
		}
	}
}
