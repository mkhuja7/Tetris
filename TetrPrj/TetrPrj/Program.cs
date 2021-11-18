using System;

namespace TetrPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 40);
            Console.SetBufferSize(30, 40);

            figure[] f = new figure[2];
            f[0]= new Square(2, 5, '*');
            f[1] = new Stick(6, 6, '*');

            foreach(figure fig in f)
            {
                fig.Draw();
            }

          

            Console.ReadLine();
        }

       
    }
}
