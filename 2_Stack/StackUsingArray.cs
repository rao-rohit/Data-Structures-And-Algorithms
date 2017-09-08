using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Stack
{
    public class StackUsingArray<T>
    {
        public T[] _list = new T[0];
        int size = 0;
       


        private bool IsEmpty
        {
            get { return size == 0; }

        }

        private bool IsFull
        {
            get { return _list.Length == size; }
        }


        public void Push(T item)
        {
            if (IsEmpty || IsFull)
                UpdateArraySize();

            _list[size] = item;
            size++;
        }

        private void UpdateArraySize()
        {
            if (_list.Count() == 0)
                _list = new T[4];
            else
            {
                //Temp array with new size, Copy all the current items to temp Array and then assign to existing _list array
                T[] tempList = new T[_list.Length * 2];
                _list.CopyTo(tempList, 0);
                _list = tempList;
            }

        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            else
            {
                //Decrement the size as tol element would be deleted
                size--;
                return _list[size];
              
            }
            

        }

        public T Peek()
        {
            if (!IsEmpty)
                return _list[0];
            else
                throw new InvalidOperationException("Stack is Empty");
        }

       

        public void Clear()
        {
            size = 0;
         
        }

        public int Count()
        {
            return size;
        }

        

       


    }
}
