using System;

namespace TetrPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 40);
            Console.SetBufferSize(30, 40);

            int x1 = 2;
            int y1 = 2;
            char c = '*';

            Draw(x1, y1, c);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
