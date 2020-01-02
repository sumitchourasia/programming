using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
	/// <summary>
	/// this class is used to permute the string using Recursive and Iterative process and stores them into 
	/// separate arrays and compare them 
	/// </summary>
	class StringPermutation
	{
		static int k = 0;
		/// <summary>
		/// StringPermutationMethod is used to permute the string using Recursive and Iterative process
		/// </summary>
		public void StringPermutationMethod()
		{
			Console.WriteLine("enter the string : ");
			string str = Utility.Util.ReadString();

			//to determine the no of permutations possible
			int len = Utility.Util.factorial(str.Length);

			string[] RecursiveArray = new string[len];
			string[] IterativeArray = new string[len];

			//recursive permutation part
			char[] chararray = new char[str.Length];
			chararray = str.ToCharArray();
			k = 0;
			RecursivePermute(RecursiveArray, chararray, 0, str.Length - 1);

			Utility.Util.PrintStringArray(RecursiveArray);



			//iterative permutaion part
			k = 0;
			int[] count = new int[chararray.Length];
			for (int i = 0; i < chararray.Length; i++)
			{
				count[i] = 1;
			}

			char[] result = new char[str.Length];

			PermuteIterative(IterativeArray, chararray, count, result, 0);
			
			Utility.Util.PrintStringArray(IterativeArray);


			bool isequal = Utility.Util.CheckTwoDistinctStringArrayEqual(IterativeArray,RecursiveArray);
			if (isequal)
				Console.WriteLine("is equal");
			else
				Console.WriteLine("not equal");
		}

		/// <summary>
		/// Permutes the string using iterative process
		/// take five parameters
		/// </summary>
		/// <param name="IterativeArray">The iterative array.</param>
		/// <param name="charray">The charray.</param>
		/// <param name="count">The count.</param>
		/// <param name="result">The result.</param>
		/// <param name="level">The level.</param>
		void PermuteIterative(string[] IterativeArray, char[] charray, int[] count, char[] result, int level)
		{
			if (level == charray.Length)
			{
				string chartostring = new string(result);
				IterativeArray[k] = chartostring;
				k++;
				Console.WriteLine(chartostring);
				return;
			}
			else
			{
				for (int i = 0; i < charray.Length; i++)
				{
					if (count[i] == 0)
					{
						continue;
					}
					result[level] = charray[i];
					count[i] = count[i] - 1;
					PermuteIterative(IterativeArray, charray, count, result, level + 1);
					count[i] = count[i] + 1; ;
				}
			}
		}




				/// <summary>
				/// RecursivePermute methhod is used to find the permutation of the string 
				/// and save all the permutaion in an array
				/// it takes five paramters
				/// </summary>
				/// <param name="RecursiveArray">The recursive array.</param>
				/// <param name="chararray">The chararray.</param>
				/// <param name="l">The l.</param>
				/// <param name="j">The j.</param>
				/// <param name="k">The k.</param>
				void RecursivePermute(string[] RecursiveArray , char[] chararray, int l, int j)
				{
					if (l == j)
					{
						string chartostring = new string(chararray);
						RecursiveArray[k] = chartostring;
						k++;
						Console.WriteLine(chararray);
					}
					else
					{
						for (int i = l; i <= j; i++)
						{
							swap(chararray, i, l);
							RecursivePermute(RecursiveArray,chararray, l + 1, j);
							swap(chararray , i, l );

						}
					}
				}

				/// <summary>
				/// Swaps the characters in the specified char array
				/// take two paramters 
				/// </summary>
				/// <param name="chararray">The chararray.</param>
				/// <param name="i">The i.</param>
				/// <param name="l">The l.</param>
				void swap(char[] chararray,int i,int l)
				{
					char temp = chararray[i];
					chararray[i] = chararray[l];
					chararray[l] = temp;
				}


	}
}
