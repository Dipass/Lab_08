using System;

namespace Lab_08
{
    internal class Box<T>
    {
        public T box { get; set; }

        public Box(T boxs)
        {
            box = boxs;
        }

        public override string ToString()
        {
            return $"Output {typeof(T).FullName}:{box}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>("sdsd");
            
            Console.WriteLine(box.ToString());
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
