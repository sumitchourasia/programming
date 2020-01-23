using System;

namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// FacadeDesignPatternTest Class for Testing the design pattern
    /// </summary>
    public class FacadeDesignPatternTest
    {
        /// <summary>
        /// FacadedesignpatterntestMethod.
        /// </summary>
        public void FacadeDesignPatternTestMethod()
        {
            ////Instantiate FacadeShoping class object
            FacadeShoping facadeObject = new FacadeShoping();

            while (true)
            {
                Console.WriteLine("enter your choice");
                Console.WriteLine(" 1 -> Buy car");
                Console.WriteLine(" 2 -> Buy Bike");
                Console.WriteLine(" 3 -> exit");

                //// input the choice
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" 1-> order petrol car ");
                        Console.WriteLine(" 2 -> order deisel car ");
                        Console.WriteLine(" 3 -> order electric car ");
                        int selectCar = Convert.ToInt32(Console.ReadLine());

                        ////order based on choice
                        switch (selectCar)
                        {
                            case 1:
                                facadeObject.OrderPetrolCar();
                                break;
                            case 2:
                                facadeObject.OrderDeiselCar();
                                break;
                            case 3:
                                facadeObject.OrderElectricCar();
                                break;
                            default:
                                Console.WriteLine("invalid selection");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine(" 1-> order petrol bike ");
                        Console.WriteLine(" 2 -> order Electric bike ");
                        Console.WriteLine(" 3 -> order cycle ");
                        int selectBike = Convert.ToInt32(Console.ReadLine());
                        switch (selectBike)
                        {
                            case 1:
                                facadeObject.OrderPetrolBike();
                                break;
                            case 2:
                                facadeObject.OrderElectricBike();
                                break;
                            case 3:
                                facadeObject.OrderCycle();
                                break;
                            default:
                                Console.WriteLine("invalid selection");
                                break;
                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }

    }
}
