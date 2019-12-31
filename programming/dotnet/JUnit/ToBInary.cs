using System;

namespace JUnit
{
    class ToBInary
    {

		public void ToBinaryMethod()
		{
			Console.Write("enter the decimal number : ");
			int n = Utility.Util.ReadInt();

			int size =Utility.Util.CalculateBinaryArraySize(n);

			int[] binaryarray = new int[size];

			binaryarray = Utility.Util.ToBinary(n,binaryarray);

			Utility.Util.PrintArray(binaryarray);

			PrintSumOfBinary(binaryarray);
			//Utility.Util.toBinary(n);

		}

		

		/// <summary>
		/// Prints the sum of binary as decimal sum.
		/// </summary>
		/// <param name="arr">The arr.</param>
		void PrintSumOfBinary(int[] arr)
		{
			int k = arr.Length-1;
			Console.WriteLine(" ");
			
			for(int i=0;i<arr.Length;i++,k--)
			{
				if((arr[i] * Math.Pow(2, k)) != 0)
				{
					Console.Write("{0}", (arr[i] * Math.Pow(2, k)));
					if(i!=arr.Length-1)
					{
						Console.Write(" + ");
					}
				}
			}

		}

	}
}
