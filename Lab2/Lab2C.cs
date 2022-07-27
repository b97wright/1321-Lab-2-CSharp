/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 2
 */

using System;

namespace Lab2
{
    class Lab2C
    {
        static void Main(string[] args)
        {
            string uI;
            int a, p, w, h;

            Console.Write("Enter a width: ");
            uI = Console.ReadLine();
            w = Convert.ToInt32(uI);

            Console.Write("Enter a height: ");
            uI = Console.ReadLine();
            h = Convert.ToInt32(uI);

            a = w * h;
            p = (w * 2) + (h * 2);

            Console.WriteLine("The area is " + a);
            Console.WriteLine("The perimeter is " + p);
;

        }
    }
}
