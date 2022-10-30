using System;

namespace Lab_08
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,x;
            Console.Write("Select a quantity n:");
            n = Convert.ToInt32(Console.ReadLine());
            List<Box<string>> box = new List<Box<string>>(n);
            List<Box<int>> box2 = new List<Box<int>>(n);

            do
            {
                Console.WriteLine("To display Problem (1): press 1 , if Problem (2): press 2 , to finish: press 3");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Add:");
                            box.Add(new Box<string>(Console.ReadLine()));
                        }
                        foreach (Box<string> stringove in box)
                        {
                            Console.WriteLine(stringove.ToString());
                        }
                        break;

                    case 2:
                        
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Add:");
                            box2.Add(new Box<int>(Convert.ToInt32(Console.ReadLine())));
                        }
                        foreach (Box<int> intove in box2)
                        {
                            Console.WriteLine(intove.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Press 3 if you want exit");
                        break;
                }
            }
            while (x != 3);

            Console.ReadLine();
        }
    }
}