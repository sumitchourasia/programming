using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class ListOfTask
    {
        public void ListOfTaskMethod( )
        {
            Console.WriteLine(" ");
			Console.WriteLine("Enter number of task to be done:");
			int n = Utility.Util.ReadInt();
			int[] darr = new int[n];
			int[] marr = new int[n];
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("The deadline for " + (i + 1) + " " + "task in minutes:");
				darr[i] = Utility.Util.ReadInt();
				Console.WriteLine("The time required for" + (i + 1) + " " + "task in minutes:");
				marr[i] = Utility.Util.ReadInt();
			}

			Utility.Util.DoBubbleSort(marr);
			Utility.Util.DoBubbleSort(darr);

			FindMinimumTime(darr,marr);
		}

        void FindMinimumTime(int[] darr , int[] marr)
        {
			

			int sum = 0;
			int sum1 = 0;
			for (int i = 0; i < darr.Length; i++)
			{
				sum = sum + darr[i];
			}
			for (int i = 0; i < marr.Length; i++)
			{
				sum1 = sum1 + marr[i];
			}
			int diff = sum - sum1;
			if (diff < 0)
			{
				Console.WriteLine("The time overshoots by following:" + " " + Math.Abs(diff));
			}
			else
				Console.WriteLine("The time completed by" + " " + (sum-diff));
		}

	}

    }


