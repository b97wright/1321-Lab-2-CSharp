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
    class Lab2A
    {
        static void Main(string[] args)
        {
            string uI;

            Console.Write("Enter a name: ");
            uI = Console.ReadLine();
            string nameOne = uI;

            Console.Write("Enter another name: ");
            uI = Console.ReadLine();
            string nameTwo = uI;

            Console.Write("Enter a verb: ");
            uI = Console.ReadLine();
            string verb = uI;

            Console.Write("Enter an adverb: ");
            uI = Console.ReadLine();
            string adVerb = uI;

            Console.WriteLine("Once upon a time, there was a person named " + nameOne + " who had a child named");
            Console.WriteLine(nameTwo + ". This child would " + verb + " " + adVerb + " while singing to strangers.");
        }
    }
}