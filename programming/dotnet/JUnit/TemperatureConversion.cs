using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
	/// <summary>
	/// class to take ask user for the choice of conversion and call the respective method and prints the result.
	/// </summary>
	class TemperatureConversion
    {
		/// <summary>
		/// Temperatures the conversion method calls respective method to convert the temperature.
		/// </summary>
		public void TemperatureConversionMethod()
		{
			Console.WriteLine("Select the conversion type : ");
			Console.WriteLine("1 for celcius to farhenheit ");
			Console.WriteLine("2 for farhenheit to celcius ");

			int choice = Utility.Util.ReadInt();
			int temp = 0;
			if (choice == 1 || choice == 2)
			{
				//reads the temperature from keyboard.
				Console.WriteLine("enter the temperature : ");
				temp = Utility.Util.ReadInt();
				Console.WriteLine(temperaturConversion(choice, temp));
			}
			else
				Console.WriteLine("invalid selction!!!");
		}

		/// <summary>
		/// based on the user choice this method converts the temperature.
		/// it take two parameters and return the converted temperature.
		/// </summary>
		/// <param name="choice">The choice.</param>
		/// <param name="temp">The temporary.</param>
		/// <returns></returns>
		double temperaturConversion(int choice , int temp )
		{

			double newtemp = 0;
			//if the user choice is 1 then converts celcius to fahrenheit.
			if (choice == 1)
			{
				int c = temp;
				Console.WriteLine(" celcius to fahrenheit ");
				newtemp = (c * (double)9 / 5) + 32;
			}
			else  ////if the user choice is 2 then converts fahrenheit to celcius .
			{
				int f = temp;
				Console.WriteLine(" fahrenheit to celcius ");
				newtemp = (f - 32) * (double)5 / 9;
			}

			return newtemp;
		}


	}
}
