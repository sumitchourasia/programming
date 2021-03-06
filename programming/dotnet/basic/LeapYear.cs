﻿using System;

namespace basic
{
    /// <summary>
    /// this class is used to check if a given year is a leap year or not
    /// </summary>
    class LeapYear
    {
        /// <summary>
        /// this method takes input from the user and calls the method checkLeapYear() and prints the result.
        /// </summary>
        public void LeapYearMethod()
        {
            Console.WriteLine("Enter the year : ");

            int  year = Utility.Util.ReadInt( );

            //input validation
            if (year > 999 && year < 10000)
            {
                //method call to check leap year.
                if (CheckLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year ", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year ", year);
                }
            }
            else
            {
                Console.WriteLine("year of should be of 4 digits");
            }

        }



        /// <summary>
        /// CheckLeapYear method is used to check if a given method is leap year 
        /// and returns a boolean true or false
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        bool CheckLeapYear(int year)
        {

            return ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));

        }

    }

   
}
