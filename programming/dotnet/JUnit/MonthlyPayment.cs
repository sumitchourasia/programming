using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
    class MonthlyPayment
    {

		public void MonthlyPaymentMethod()
		{
			Console.WriteLine("enter the principle amount : ");
			double principle = Utility.Util.ReadDouble();
			Console.WriteLine("enter the years : ");
			double years = Utility.Util.ReadDouble();
			Console.WriteLine("enter the rate of interest : ");
			double rate = Utility.Util.ReadDouble();

			double MonthlyPayment = CalculateMonthlyPayment(principle, years, rate);
			Console.WriteLine("monthly payment is {0}: ", MonthlyPayment);

		}

		double CalculateMonthlyPayment(double principal, double years, double rate)
		{

			double n = 12 * years;
			double r = rate / 12 * 100;

			double payment = (principal * rate) / (1.0 - Math.Pow((1 + r), (-n)));

			double MonthlyPayment = payment / 12;
			return MonthlyPayment;
		}

		

	}
}
