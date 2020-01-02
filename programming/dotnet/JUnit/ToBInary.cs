using System;

namespace JUnit
{
	/// <summary>
	/// class to take input from the user and [prints the binary representation of the decimal value. 
	/// </summary>
	class ToBInary
    {
		/// <summary>
		/// this methof takes the user input and calls the utility method to convert the input to binary representation 
		/// and prints that binary representation.
		/// </summary>
		public void ToBinaryMethod()
		{
			Console.Write("enter the decimal number : ");
			int n = Utility.Util.ReadInt();

			//size of the binary array that is required to hold the binary representation.
			int size =Utility.Util.CalculateBinaryArraySize(n);

			int[] binaryarray = new int[size];

			//utility method called for binary conversion.
			binaryarray = Utility.Util.ToBinary(n,binaryarray);

			//utility method called to print the binary array.
			Utility.Util.PrintBinaryArray(binaryarray);

			//prints the sum representation of the binary number.
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
				//print only the values that is greater than 0.
				if(arr[i] != 0)
				{
					//print the sum of power.
					Console.Write("{0}", (arr[i] * Math.Pow(2, k)));

					if(i != arr.Length-1)
					{
						Console.Write(" + ");
					}
				}
			}

		}

	}
}
