using System;

namespace JUnit
{
    class ToBinary
    {

		public void ToBinaryMethod()
		{
			Console.Write("enter the decimal number : ");
			int n = Utility.Util.ReadInt();

			Utility.Util.toBinary(n);

		}

	}
}
