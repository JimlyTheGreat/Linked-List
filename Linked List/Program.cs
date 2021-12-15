using System;
using System.Net.Http.Headers;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList test = new LinkedList();
            test.AddNewNode(2);
            test.AddNewNode(7);
            test.AddNewNode(15);
            test.AddNewNode(5);
            test.AddNewNode(3);

            test.DisplayAllNodeValues();
        }
    }

    public class LLNode
    {
        public LLNode next;
        public int data;

        public LLNode(int Data)
        {
            SetData(Data);
            next = null;
        }

        public void SetData(int Data)
        {
            data = Data;
        }

        public void SetNext(LLNode newNode)
        {
            next = newNode;
        }

        public int GetData()
        {
            return data;
        }

        public LLNode GetNext()
        {
            return next;
        }
    }

    class LinkedList
    {
        public LLNode front;
        public LLNode back;
        public LLNode current;


        public void AddNewNode(int data)
        {
            LLNode newNode = new LLNode(data);

            if(front == null)
            {
                front = newNode;
                current = newNode;
                back = newNode;
            }
            else
            {
                current.SetNext(newNode);
                current = newNode;
                back = newNode;
            }
        }

        public void DisplayAllNodeValues()
        {
            current = front;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void SetFront(int data)
        {
            LLNode newNode = new LLNode(data);

            newNode.next = front.next;
            front = newNode;
        }

        public void SetBack(int data)
        {
            LLNode newNode = new LLNode(data);

            back = newNode;
        }

        public void SetCurrent(int data)
        {
            LLNode newNode = new LLNode(data);

            newNode.next = current.next;
            current = newNode;
        }

        public LLNode GetFront()
        {
            return front;
        }

        public LLNode GetBack()
        {
            return back;
        }

        public LLNode GetCurrent()
        {
            return current;
        }
    }
}
