using System;

namespace Algorithm
{
    class GuessNumber
    {
		public void GuessNumberMethod()
		{
			//asking user to guess anumber
			Console.WriteLine("guess a no between 0 to 127 ");
			int number = -1;
			while (number < 0 || number > 127)
			{
				number = Utility.Util.ReadInt();
			}
			
			Console.Write("guessed number is : {0} ",FindGuessNumber());

		}


		int FindGuessNumber()
		{
			int low = 0, high = 127, mid;
			while (low != high)
			{
				mid = (low + high) / 2;
				Console.WriteLine("enter 1 if no is between " + low + " - " + mid + "\nEnter 2 if no is between "
						+ (mid + 1) + " - " + high);
				int c = Utility.Util.ReadInt();
			
				if (c == 1)
					high = mid;
				else
					low = mid + 1;
			}
			return low;
		}

	}

}
