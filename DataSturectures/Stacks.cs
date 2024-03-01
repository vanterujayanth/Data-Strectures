using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSturectures
{
    class Stack
    {
        public int Count { get; private set; }
        private int[] stack;
        public Stack(int size)
        {
            stack = new int[size];
            Count = 0;

        }
        public void push(int value)
        {
            if (Count == stack.Length)
            {
                Console.WriteLine("the stack is full :");
            }
            else
            {
                stack[Count++] = value;
            }
        }
        public void pop()
        {
            int result = -1;
            if (Count == 0)
            {
                Console.WriteLine("stack is empty :");
            }
            else
            {
                result = stack[--Count];
            }

        }
        public void Display()
        {
            if (Count == 0)
            {
                Console.WriteLine("stack does't contain  the  data :");
            }
            else
            {
                Console.WriteLine("staxck contain data :");
                for (int i = Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
