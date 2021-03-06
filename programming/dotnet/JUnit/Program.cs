﻿using System;

namespace JUnit
{
    class Program
    {
        static void Main( )
        {
            Console.WriteLine(" Enter your choice ");
            Console.WriteLine(" 1 -> Vending Machine ");
            Console.WriteLine(" 2 -> DayOfWeek Program ");
            Console.WriteLine(" 3 -> TemperatureConversion program ");
            Console.WriteLine(" 4 -> MonthlyPayment program ");
            Console.WriteLine(" 5 -> NewtonSqrt program ");
            Console.WriteLine(" 6 -> ToBinary program ");
            Console.WriteLine(" 7 -> ToBinaryAndSwapNibble program ");

            int choice = Utility.Util.ReadInt();

            switch (choice)
            {
                case 1:
                    VendingMachine vm = new VendingMachine();
                    vm.VendingMachineMethod();
                    break;

                case 2:
                    DayOfWeek dow = new DayOfWeek();
                    dow.DayOFWeekMethod();
                    break;

                case 3:
                    TemperatureConversion tc = new TemperatureConversion();
                    tc.TemperatureConversionMethod();
                    break;

                case 4:
                    MonthlyPayment mn = new MonthlyPayment();
                    mn.MonthlyPaymentMethod();
                    break;

                case 5:
                    NewtonSqrt nsqrt = new NewtonSqrt();
                    nsqrt.NewtonSqrtMethod();
                    break;

                case 6:
                    ToBInary tobinary = new ToBInary();
                    tobinary.ToBinaryMethod();
                    break;

                case 7:
                    ToBinaryAndSwapNibble tbsn = new ToBinaryAndSwapNibble();
                    tbsn.ToBinaryAndSwapNibbleMethod();
                    break;

                default:
                    Console.WriteLine("default run");
                    break;

            }
        }
    }
}
