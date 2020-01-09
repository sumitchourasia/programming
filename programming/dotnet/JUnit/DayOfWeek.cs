using System;
  
namespace JUnit
{
	/// <summary>
	/// class to take date as input and print the day.
	/// </summary>
	class DayOfWeek
    {
		/// <summary>
		/// method to take in the date as input and call the method CalculateDayOfWeek and print it
		/// </summary>
		public void DayOFWeekMethod()
		{
			//input the date month and year.
			Console.Write("enter the date : ");
			int date = Utility.Util.ReadInt();

			Console.Write("enter the month : ");
			int month = Utility.Util.ReadInt();

			Console.Write("enter the year : ");
			int year = Utility.Util.ReadInt();

			//method call
			int daynumber = Utility.Util.CalculateDayOfWeek(date, month, year);

            //DayOfWeek is selected on the basic of d0 value. sunday for 0 and so on.
            switch (daynumber)
            {
                case 0:
                    {
                        Console.WriteLine("sunday");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("saturday");
                        break;
                    }
                default:
                    Console.WriteLine("error");
                    break;
            }

        }



	}
}
