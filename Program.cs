namespace StackAndQueue
{
    class program
    {
        public static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Pop();


            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.EnQueue(56);
            linkedListQueue.EnQueue(30);
            linkedListQueue.EnQueue(70);

            linkedListQueue.Dequeue(56);
            linkedListQueue.Dequeue(30);
            linkedListQueue.Dequeue(70);
            linkedListQueue.Display();



        }
    }
}