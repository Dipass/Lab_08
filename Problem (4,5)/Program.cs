using System;

namespace Problem_4_5
{
    class Program
    {
        static void For_Swap<T>(List<Box<T>> masiv, int initials, int lasts)
        {
            Box<T> start = masiv[initials];
            masiv[initials] = masiv[lasts];
            masiv[lasts] = start;
        }
        static void Main()
        {
            int n,x;
            int initial, last;
            Console.Write("Select a quantity n:");
            n = Convert.ToInt32(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>(n);
            List<Box<int>> boxes2 = new List<Box<int>>(n);

            do
            {
                Console.WriteLine("To display Problem (3): press 1 , if Problem (4): press 2 , to finish: press 3");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Add:");
                            boxes.Add(new Box<string>(Console.ReadLine()));
                        }
                        Console.Write("Select initial index:");
                        initial = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Select last index:");
                        last = Convert.ToInt32(Console.ReadLine());

                        For_Swap<string>(boxes, initial, last);
                        foreach (Box<string> box in boxes)
                        {
                            Console.WriteLine(box.ToString());
                        }
                        break;
                    case 2:
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Add:");
                            boxes2.Add(new Box<int>(Convert.ToInt32(Console.ReadLine())));
                        }
                        Console.Write("Select initial index:");
                        initial = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Select last index:");
                        last = Convert.ToInt32(Console.ReadLine());

                        For_Swap<int>(boxes2, initial, last);
                        foreach (Box<int> box in boxes2)
                        {
                            Console.WriteLine(box.ToString());
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