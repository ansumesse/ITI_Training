using GenericStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal class Stack<T> : IGetByIndex<T>
    {
        int pointer;
        public readonly int size;
        T[] stack;
       
        public void Push(T n)
        {
            if(pointer <= size)
            {
                stack[pointer] = n;
                pointer++;
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }
        public T Pop()
        {
            if(pointer > 0)
            {
                return stack[--pointer];
            }
            else
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
        }

        public T GetByIndex(int index)
        {
            return stack[index];
        }

        public Stack(int size)
        {
            this.size = size;
            stack = new T[size];
            pointer = 0;
        }
        public T this[int index]
        {
            get { return stack[index]; }
            set { stack[index] = value; }
        }

       
    }
}
