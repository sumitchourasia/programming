using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
    class TemperatureConversion
    {
		public void TemperatureConversionMethod()
		{
			Console.WriteLine("Select the conversion type : ");
			Console.WriteLine("1 for celcius to farhenheit ");
			Console.WriteLine("2 for farhenheit to celcius ");

			int choice = Utility.Util.ReadInt();
			int temp = 0;
			if (choice == 1 || choice == 2)
			{
				Console.WriteLine("enter the temperature : ");
				temp = Utility.Util.ReadInt();
				Console.WriteLine(temperaturConversion(choice, temp));
			}
			else
				Console.WriteLine("invalid selction!!!");


		}


		double temperaturConversion(int choice , int temp )
		{

			double newtemp = 0;
			if (choice == 1)
			{
				int c = temp;
				Console.WriteLine(" celcius to fahrenheit ");
				newtemp = (c * (double)9 / 5) + 32;
			}
			else
			{
				int f = temp;
				Console.WriteLine(" fahrenheit to celcius ");
				newtemp = (f - 32) * (double)5 / 9;
			}
			return newtemp;
		}


	}
}
