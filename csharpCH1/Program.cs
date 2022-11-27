using System;
namespace NetWork3
{
    class MyStack<T>
    {
        public T[] Items;
        public int id;
        public MyStack()
        {
            Items = new T[1000];
            for (int i = 0; i < 1000; i++)
            {
                Items[i] = default(T);
            }
            id = -1;
        }

        public bool Push(T item)//入栈
        {
            id++;
            Items[id] = item;
            return true;
            if (id >= 1000)
            {
                Console.WriteLine("栈已满");
                return false;
            }
        }
        public T Pop()//出栈
        {
            if (id == -1)
            {
                Console.WriteLine("该栈是空栈");
            }
            T factory = Items[id];
            Items[id] = default(T);
            id--;
            return factory;

        }
        public void print()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine(Items[i]);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var stackInt = new MyStack<int>();
            stackInt.Push(3);
            stackInt.Push(5);
            stackInt.Push(7);
            stackInt.Pop();
            stackInt.print();
        }
    }

}

