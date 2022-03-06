using System;
using System.Collections.Generic;
using System.Text;

namespace Nelinurk
{
    class Nelinurk
    {
        string tüüp;
        int status;
        double kõrgus;
        double laius;
        public Nelinurk() { }
        public Nelinurk(double Kõrgus, double Laius)
        {
            kõrgus = Kõrgus;
            laius = Laius;
        }
        public string Tüüp
        {
            get
            {
                if (kõrgus == laius || status != 90)
                {
                    tüüp = "Romb";
                }
                else if (kõrgus == laius || status == 90)
                {
                    tüüp = "Ruut";
                }
                else
                {
                    tüüp = "ristkülik";
                }
                return tüüp;
            }
        }
        public int Status
        {
            set { }
            get { return status; }
        }
        public double Pindala()
        {
            double S = 0;
            S = kõrgus * laius;
            return S;
        }
        public double Perimeeter() // 
        {
            double P = 0;
            P = (kõrgus + laius) * 2;
            return P;
        }
        public void Vastus()
        {
            Console.WriteLine($"S = {S}"); //площадь
            Console.WriteLine($"P = {P}"); //периметр 
        }
    }
}