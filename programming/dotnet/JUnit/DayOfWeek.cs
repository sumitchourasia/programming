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
            int maxDate = 31;
            int daynumber = 0;
            //input the date month and year.
            Console.Write("enter the date : ");
			int date = Utility.Util.ReadInt();

			Console.Write("enter the month : ");
			int month = Utility.Util.ReadInt();

			Console.Write("enter the year : ");
			int year = Utility.Util.ReadInt();

            ////determine the month is of 31 or 30 or 28 or 29 days.
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                maxDate = 31;
            }
            else if (month == 2)
            {
                if (Utility.Util.CheckLeapYear(year))
                {

                    maxDate = 29;
                }
                else
                    maxDate = 28;
            }
            else
            {
                maxDate = 30;

            }


            if (date <= maxDate)
            {
                daynumber = Utility.Util.CalculateDayOfWeek(date, month, year);
            }
            else
            {
                Console.WriteLine("date is incorrect ");
                return ;
            }
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
