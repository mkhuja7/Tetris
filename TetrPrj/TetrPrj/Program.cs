using System;

namespace TetrPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 40);
            Console.SetBufferSize(30, 40);


            Points p1 = new Points();
            p1.x = 2;
            p1.y = 3;
            p1.c = '*';
            p1.Draw();


            Console.ReadLine();
        }

       
    }
}
