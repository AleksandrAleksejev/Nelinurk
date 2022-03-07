using System;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            int Korgus;
            int Laius;
            


            Console.WriteLine("Sisesta Korgus ");
            Korgus = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta Laius ");
            Laius = int.Parse(Console.ReadLine());

            Nelinurk N = new Nelinurk(Korgus,Laius);
            N.Vastus();
            Console.ReadKey();



            Console.ReadKey();
        }
    }
}
