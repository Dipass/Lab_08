using System;

namespace prop
{
    class Program
    {
        static void Main()
        {
            int length = 0;
            string news;
            string cont, greater;
            int initial, last;
            Console.Write("Selectr length array:");
            length = Convert.ToInt32(Console.ReadLine());
            Box<string> box = new Box<string>(length);

            for (int i = 0; i < length; i++)
            {
                Console.Write("Add:");
                news = Console.ReadLine();

                box.Add(news);
            }
            Console.Write("Array:");
            box.Print();

            Console.WriteLine("Max element in array:");
            Console.WriteLine(box.Max);
            Console.WriteLine("Min element in array:");
            Console.WriteLine(box.Min);

            Console.WriteLine("Contins in array:");
            cont=Console.ReadLine();
            Console.WriteLine(box.Contains(cont));

            Console.WriteLine("Greater in array:");
            greater = Console.ReadLine();
            Console.WriteLine(box.Greater(greater));

            Console.WriteLine("Swap array:");
            Console.WriteLine("Select initial in array:");
            initial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select last in array:");
            last = Convert.ToInt32(Console.ReadLine());
            box.Swap(initial, last);
            Console.WriteLine(box);

            Console.ReadLine();
        }
    }


}