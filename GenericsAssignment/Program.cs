using System;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackElement();

            var cust1 = new CustomerRecord("schirle", "nathan", "1");
            var cust2 = new CustomerRecord("test", "a", "2");
            var cust3 = new CustomerRecord("test", "b", "3");

            stack.Push(cust1);
            stack.Push(cust2);
            stack.Push(cust3);
            foreach(var c in stack)
            {
                Console.WriteLine(c.ToString());
            }
            /*Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();*/
        }
    }
}
