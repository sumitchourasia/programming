using System;

namespace DataStructures.Calender
{
    class Calender2D
    {
        public void Calender2DMethod()
        {
            string[,] CalenderArray = new string[6,7];



            for (int i=0;i<6;i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        CalenderArray[0, k] = DayNumber(k);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < 7; j++)
                    {

                        CalenderArray[i, j] = " 0 ";
                    }
                }
            }



            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (CalenderArray[i, j] != " 0 ")
                        Console.Write(" {0} ", CalenderArray[i, j]);
                }
                Console.WriteLine(" ");
            }




            Console.WriteLine("enter the month and year");
            int month = Utility.ReadInt();
            int year = Utility.ReadInt();
            int date = 1;
            int maxDate = 30;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                maxDate = 31;
            }
            else if( month == 2 )
            {
                if (Utility.CheckLeapYear(year))
                {
                    
                    maxDate = 29;
                    Console.WriteLine("month " + month);
                }
                else
                    maxDate = 28;
            }
            else
            {
                maxDate = 30;

            }


            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 7 && date <= maxDate; j++)
                {
                    int val = Utility.CalculateDayOfWeek(date, month, year);
                    Console.WriteLine("date :{0} and val : {1}",date,val);
                    j = val;
                    CalenderArray[i, val] = " "+date+" ";
                    date++;
                }
            }

                
          
          

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 1 )
                        Console.Write(" {0} ", CalenderArray[i, j]);
                    else
                    {
                        if ( CalenderArray[i, j] != " 0 ")
                            Console.Write(" {0} ", CalenderArray[i, j]);
                    }
                }
                Console.WriteLine();
            }



            /*

          for(int i=0;i<7;i++)
          {
              CalenderArray[i] = new string[7];
          }
          */


        }

        public string DayNumber(int daynumber)
        {

            //DayOfWeek is selected on the basic of d0 value. sunday for 0 and so on.
            switch (daynumber)
            {
                case 0:
                    {
                       return " S " ;
                    }
                case 1:
                    {
                        return " M ";
                    }
                case 2:
                    {
                        return " T ";
                    }
                case 3:
                    {
                        return " W ";
                    }
                case 4:
                    {
                        return " Th ";
                    }
                case 5:
                    {
                        return " F ";
                    }
                case 6:
                    {
                        return " S ";
                    }
                default:
                    
                    return " o ";
            }

            
        }

    }
}

