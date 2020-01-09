using System;


namespace DataStructures.BalancedParanthesis
{
    class Balanced_Paranthesis<T>
    {
        public void BalancedParanthesisMethod()
        {
            Stack<char> S = Utility.CreateArrayStack<char>();

            Console.WriteLine("enter the expression");
            string expression = Utility.ReadString();

            char[] chararray = new char[expression.Length];

            chararray = expression.ToCharArray();

            foreach(char c in chararray)
            {
                Console.WriteLine(c);
            }

            for (int i = 0; i < chararray.Length; i++)
            {
                if (chararray[i] == '(')
                {
                    if (Utility.IsFullStack(S))
                    {
                        Console.WriteLine("Stack is Full");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(" element to push "+chararray[i]);
                        Utility.Push(S, chararray[i]);
                    }

                    Console.WriteLine(" Top "+Utility.Peek<char>(S));

                }
                else if (chararray[i] == ')')
                {
                    if (Utility.IsEmptyStack(S) || S.Array[S.Top] != '(')
                    {
                        Console.WriteLine("invalid expression");
                        return;
                    }
                    if (S.Array[S.Top] == '(')
                    {
                       Console.WriteLine(" before poping "+Utility.Peek<char>(S));
                        Utility.Pop(S);
                        Console.WriteLine("after poping "+Utility.Peek<char>(S));
                    }
                }
            }
                
            if(Utility.IsEmptyStack(S))
            {
                Console.WriteLine("balanced paranthesis"); 
            }
            else
            {
            Console.WriteLine("Not balanced");
            }
            


        }



    }
}
