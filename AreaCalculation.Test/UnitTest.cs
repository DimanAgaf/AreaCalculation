namespace AreaCalculation.Test
{
	public class UnitTest
	{
		[Fact]
		public void GetCircleAreaPassingTest()
		{
			IAreaCalculations areaCalculations = new AreaCalculations();

			Assert.Equal(19.63, areaCalculations.GetCircleArea(2.5));
		}

		[Fact]
		public void GetTriangleAreaPassingTest()
		{
			IAreaCalculations areaCalculations = new AreaCalculations();

			Assert.Equal(2.9, areaCalculations.GetTriangleArea(2, 3, 4));
		}

		//[Fact]
		//public void GetCircleAreaFailingTest()
		//{
		//	IAreaCalculations areaCalculations = new AreaCalculations();

		//	Assert.Equal(0, areaCalculations.GetCircleArea(2.5));
		//}

		//[Fact]
		//public void GetTriangleAreaFailingTest()
		//{
		//	IAreaCalculations areaCalculations = new AreaCalculations();

		//	Assert.Equal(0, areaCalculations.GetTriangleArea(2, 3, 4));
		//}
	}
}