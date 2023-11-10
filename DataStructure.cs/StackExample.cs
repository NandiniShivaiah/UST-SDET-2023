using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class StackExample<T>

    {
        private T[] stackArray;
        private int top;
        private int maxSize;

        public StackExample(int size)
        {
            maxSize = size;
            stackArray = new T[maxSize];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

    }
}
