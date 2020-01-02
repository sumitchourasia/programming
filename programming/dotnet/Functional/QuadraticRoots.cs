using System;


namespace Functional
{
    /// <summary>
    /// used to stroe the two roots of the given quadratic co-efficient
    /// </summary>
    struct Roots
    {
        public double root1;
        public double root2;
    };

    /// <summary>
    /// this class is use to calculate quadratic roots of a quadratic equation
    /// it takes co-efficient as the innput and calls the method FindQuadraticRoots and prints the roots.
    /// </summary>
    class QuadraticRoots
    {
        public void QuadraticRootsMethod()
        {
            //take co-efficients as inputs 
            Console.WriteLine("enter the co-efficient a b and c of the quadratic equation : ");
            int a = Utility.Util.ReadInt();
            int b = Utility.Util.ReadInt();
            int c = Utility.Util.ReadInt();
            
            //structure creation code
            Roots roots = new Roots();

            //method to find quadratic equation
            roots = FindQuadraticRoots(a, b, c);

            if (roots.root1 != 0.0 && roots.root2 != 0.0)
            {
                Console.WriteLine("Root1 : {0}", roots.root1);
                Console.WriteLine("Root2 : {0}", roots.root2);
            }
            else
            {
                Console.WriteLine("real roots not possible" );
            }
            
        }

        /// <summary>
        /// Finds the quadratic roots and store them in struct type and return the roots
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns>structure type </returns>
        static Roots FindQuadraticRoots(double a, double b, double c)
        {
            Roots roots = new Roots();

            double delta = ((b * b) - (4 * a * c));
            //check if the roots are complex or real number.
            if (delta >= 0)
            {
                roots.root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                roots.root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }

            return roots;
        }



    }
}
