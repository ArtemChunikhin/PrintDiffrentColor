using System;

namespace PrintDiffrentColor
{
    internal class Printer
    {
        protected String value = "One";
        public  virtual void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[{0}]", value);
        }
    }
    internal class PrintTwoWords : Printer
    {
        new String value = "Two Two";
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[{0}]", value);
        }
    }
    internal class PrintThreeWords : Printer
    {
        new String value = "Three Three Three";
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[{0}]", value);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer[] printers = { new Printer(), new PrintTwoWords(), new PrintThreeWords() };
            foreach(Printer p in printers)
            {
                p.Print();
                Console.WriteLine();
            }


        }
    }
}
