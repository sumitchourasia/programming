using System;

namespace Logical
{
    /// <summary>
    /// this class take the distinct coupons and store it in the array.
    /// and generates random numbner to match it with the coupons array passed.
    /// and prints the total random number generated.
    /// </summary>
    class CouponNumbers
    {
        int total;
        int hit;
        int len;
        int[] CouponArray;

        /// <summary>
        ///this method takes the dictinct coupon as input and calls ProcessDistinctCoupon method to 
        ///compare each coupon with the generated coupon array.
        ///and prints the total random number count.
        /// </summary>
        public void CouponNumberMethod()
        {
            Console.Write("enter the number of coupons :");
            len = Utility.Util.ReadInt();

            CouponArray = new int[len];
            Console.WriteLine("enter the Distinct Array");
            Utility.Util.InputDistinctArray(CouponArray);

            //method call to process the distinct coupons with generated random number.
            ProcessDistinctCoupon(CouponArray);

            Console.WriteLine("total number of random number generated {0}",total);
            Console.WriteLine("hit count : "+hit);

        }

        /// <summary>
        /// Processes the distinct coupon and returns total number of times random number was generated 
        /// to match all the coupon.
        /// </summary>
        /// <param name="arr">The arr.</param>
        void ProcessDistinctCoupon(int[] arr)
        {
            int random = -1;
            //loop thorough the entire coupon array
            while(hit<=arr.Length)
            {
                //utility method to generate random numbers.
                random = Utility.Util.GenerateRandomInteger(10);
                total++;
                //compare each coupon array element with the random number.
                for(int i=0;i<arr.Length;i++)
                {
                    if(random == arr[i])
                    {
                        hit++;
                        arr[i] = -1;
                        break;
                    }
                }
            }
        }

        

    }
}

