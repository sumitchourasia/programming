using System;


namespace DataStructures
{
    class PrimeAnagram_Queue_LinkedLIst<T>
    {
        public void PrimeAnagram_Queue_linkedList_Method()
        {
            QueueLL<T> QLL =Utility.CreateQueueLL<T>();

            string str1 = string.Empty;
            string str2 = string.Empty;

            for (int i=2;i<=1000;i++)
            {
                if(Utility.IsPrime(i))
                {
                    for(int j=0;j<=1000;j++)
                    {
                        if(Utility.IsPrime(j) && i != j )
                        {
                            str1 = i.ToString();
                            str2 = j.ToString();
                            if (!Utility.SearchItem(QLL.Front, str1))
                            {
                                if (Utility.CheckAnagram(str1,str2))
                                {
                                    Utility.EnqueQLL(QLL,(T)((object)str1));
                                }
                            }

                        }


                    }

                }



            }

            Utility.PrintQLL(QLL);

        }

      

    }
}
