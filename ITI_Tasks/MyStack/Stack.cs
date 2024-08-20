using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class Stack
    {
        int pointer;
        public readonly int size;
        int[] stack;

        public void Push(int n)
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
        public int Pop()
        {
            if(pointer > 0)
            {
                return stack[--pointer];
            }
            else
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
        }
        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
            pointer = 0;
        }
        public static Stack operator +(Stack s1, Stack s2)
        {
            Stack s3 = new Stack(s1.size + s2.size);
            while (s1.pointer > 0)
            {
                s3.Push(s1.Pop());
            }
            while (s2.pointer > 0)
            {
                s3.Push(s2.Pop());
            }
            return s3;
        }
        public int this[int index]
        {
            get { return stack[index]; }
            set { stack[index] = value; }
        }

        public static implicit operator int[](Stack s)
        {
            return s;
        }
        public static explicit operator Stack(int[] array)
        {
            Stack s = new Stack(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                s[i] = array[i];
            }
            return s;
        }
    }
}
