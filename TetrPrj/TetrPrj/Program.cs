using System;

namespace TetrPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 40);
            Console.SetBufferSize(30, 40);


            Points p1 = new Points(2,3,'*');

            p1.Draw();

            Console.ReadLine();
        }

       
    }
}
