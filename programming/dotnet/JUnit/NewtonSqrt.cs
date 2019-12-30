using System;

namespace JUnit
{
    class NewtonSqrt
    {

		public void NewtonSqrtMethod()
		{
			Console.WriteLine("enter the number : ");
			int c = Utility.Util.ReadInt();

			if (c < 0)
			{
				Console.WriteLine("enter nonnegative number");
			}

			double sqrt = Utility.Util.CalculateNewtonSqrt((double)c);

			Console.WriteLine("Newton sqrt : {0} ", sqrt);

		}

	}
}
