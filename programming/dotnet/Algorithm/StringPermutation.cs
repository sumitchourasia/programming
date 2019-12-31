using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class StringPermutation
    {
		public void StringPermutationMethod()
		{
			Console.WriteLine("enter the string : ");
			string str = Utility.Util.ReadString();

			char[] chararray = new char[str.Length];
			int[] count = new int[chararray.Length];

			chararray = str.ToCharArray();

			char[] result = new char[str.Length];


			permute(chararray, count, result, 0);
		}


		void permute(char[] charray, int[] count, char[] result, int level)
		{
			if (level == charray.Length)
			{

			 	Utility.Util.PrintCharArray(result);
				return;
			}

			for (int i = 0; i < charray.Length; i++)
			{
				if (count[i] == 0)
				{
					continue;
				}
				result[level] = charray[i];
				count[i]--;
				permute(charray, count, result, level + 1);
				count[i]++;
			}
		}
	}



}
