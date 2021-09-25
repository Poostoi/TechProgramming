using System;

namespace threeTask
{
	public class Class1
	{
		public static double FindTheMeanOfThree(double firstNumber, double secondNumber, double thirdNumber)
		{
			System.Console.WriteLine();
			if (secondNumber == thirdNumber)
				throw new ArgumentException("Второе и третье число равны. ");
			return (firstNumber + secondNumber + thirdNumber) / 3;
		}
		public static bool IsTheYearALeapYear(int year)
		{
			if (year % 100 == 0)
			{
				return year % 400 == 0;
			}
			return year % 4 == 0;
		}
		public static double FindValueY(double x)
		{
			if (x > 0)
			{
				return x / 2;
			}
			else if (x < 0)
			{
				return x * 2;
			}
			else
			{
				throw new ArgumentException("Такого x не существует");
			}
		}

	}
}
