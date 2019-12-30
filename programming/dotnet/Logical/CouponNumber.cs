using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{
    class CouponNumbers
    {
        int total;
        int hit;
        int len;
        int[] CouponArray;
        public void CouponNumberMethod()
        {
            Console.Write("enter the number of coupons :");
            len = Utility.Util.ReadInt();
            CouponArray = new int[len];
            Console.WriteLine("enter the Distinct Array");
            Utility.Util.InputDistinctArray(CouponArray);

            ProcessDistinctCoupon(CouponArray);

            Console.WriteLine("total number of random number generated {0}",total);
            Console.WriteLine("hit count : "+hit);

        }

        /// <summary>
        /// Processes the distinct coupon and return total number of times random number was generated 
        /// to match all the coupon.
        /// </summary>
        /// <param name="arr">The arr.</param>
        void ProcessDistinctCoupon(int[] arr)
        {
            int random = -1;
            while(hit<=arr.Length)
            {
                random = Utility.Util.GenerateRandomInteger(10);
                total++;
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

