using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagram_Queue_LinkedLIst<T>
    {
        public void PrimeAnagram_Queue_linkedList_Method()
        {
            QueueLL<T> QLL = CreateQueueLL<T>();





        }

        public QueueLL<T> CreateQueueLL<T>()
        {
            QueueLL<T> queue = new QueueLL<T>();
            return queue;
        }

        public bool IsEmptyQLL<T>(QueueLL<T> Q)
        {
            return Q.Front == null;
        }

        public void EnqueQLL<T>(QueueLL<T> Q , T item)
        {
            ListNode<T> newnode = new ListNode<T>();
            newnode.data = item;

            if(Q.Rear == null)
            {
                Q.Rear = newnode;
            }
            else
            {
                Q.Rear.next = newnode;
                Q.Rear = newnode;
            }

            if(Q.Front == null)
            {
                Q.Front = Q.Rear;
            }
        }

        public int DequeLL<T>(QueueLL<T> Q)
        {
            ListNode<T> temp;

            if(Q.Front == null)
            {
                return -1;
            }
            else
            {
                temp = Q.Front;
                Q.Front = Q.Front.next;
            }

            return ((int)((object)temp.data));
        }

        public int SizeQLL<T>(QueueLL<T> Q)
        {
            ListNode<T> temp;
            int count = 0;
            if(Q.Front == null)
            {
                return count;
            }
            else
            {
                temp = Q.Front;
                while(temp!=null)
                {
                    count++;
                    temp = temp.next;
                }
            }
            return count;
        }


    }
}
