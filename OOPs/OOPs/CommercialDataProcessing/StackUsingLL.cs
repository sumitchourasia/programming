using System;

namespace OOPs.CommercialDataProcessing
{
    public class StackUsingLL
    {
        public ListNodeStatus head;

        public bool IsEmptyStack()
        {
            return head == null;
        }

        public void push(string item)
        {
            ListNodeStatus newnode = new ListNodeStatus();
            newnode.Status = item;
            
            if (head == null)
                head = newnode;
            else
            {
                newnode.Next = head;
                head = newnode;
            }
        }

        public string pop()
        {
            ListNodeStatus temp = null;
            if (head == null)
                return null;
            else
            {
                temp = head;
                head = head.Next;
            }
            return temp.Status;
        }

        public string Top()
        {
            if (head == null)
                return null;
            else
                return head.Status;
        }

    }

    
}
