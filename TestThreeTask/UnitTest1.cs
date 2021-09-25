using System;
using Xunit;
using threeTask;

namespace TestThreeTask
{
	public class UnitTest1
	{

		[Fact]
		public void FindTheMeanOfThree_SecondThirdEqual_True()
		{
			//Arrange

			//Act

			//Assert			
			Assert.Throws<ArgumentException>(() => Class1.FindTheMeanOfThree(1, 3, 3));
		}

		[Fact]
		public void IsTheYearALeapYear_CheckIfFourNumberLeapYear_False()
		{
			//Arrange
			var fourNumber = new int[4]
			{
				1900,2000,1994,1700
			};
			bool check = true;
			//Act
			foreach (var number in fourNumber)
			{
				check = check && Class1.IsTheYearALeapYear(number);
			}
			//Assert
			Assert.False(check);
		}
		[Fact]
		public void FindValueY_XLessZero_True()
		{
			//Arrange
			double xLessZero = -2;
			//Act
			var check = -4 == Class1.FindValueY(xLessZero);
			//Assert
			Assert.True(check);
		}
		[Fact]
		public void FindValueY_XGreaterZero_True()
		{
			//Arrange
			double xGreaterZero = 4;

			//Act
			var check = 2 == Class1.FindValueY(xGreaterZero);
			//Assert
			Assert.True(check);
		}
		[Fact]
		public void FindValueY_XEqualsZero_ArgumentException()
		{
			//Arrange			
			double xEqualsZero = 0;
			//Act			

			//Assert
			Assert.Throws<ArgumentException>(() => Class1.FindValueY(xEqualsZero));
		}

	}
}
