using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedListStack
    {
        public Node top; 

        public LinkedListStack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(" {0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
                while(temp != null)
                {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                }
        }
        public void Peek()
        {

            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty,Deletion is not possible");
            }
            Console.WriteLine("value popped is {0}", this.top.data);
            this.top = this.top.next;

        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
