using System;
using System.Collections;

namespace DataStack
{
    class Program
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push(8);
            stack.Push(1);

            //Console.WriteLine($"length = {stack.Count}");
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine($"length = {stack.Count}");

            //stack.Clear();
            //Console.WriteLine(stack.Contains(4));
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}