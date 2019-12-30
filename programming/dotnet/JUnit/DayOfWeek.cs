using System;
  
namespace JUnit
{
    class DayOfWeek
    {
		public void DayOFWeekMethod()
		{

			Console.Write("enter the date : ");
			int date = Utility.Util.ReadInt();

			Console.Write("enter the month : ");
			int month = Utility.Util.ReadInt();

			Console.Write("enter the year : ");
			int year = Utility.Util.ReadInt();

			CalculateDayOfWeek(date, month, year);

		}


		void CalculateDayOfWeek(int d, int m, int y)
		{
			int d0 = 0;
			int m0 = 0;
			int y0 = 0;
			int x = 0;

			y0 = y - (14 - m) / 12;

			x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);

			m0 = m + 12 * ((14 - m) / 12) - 2;

			d0 = (d + x + (31 * m0) / 12) % 7;

			switch (d0)
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
