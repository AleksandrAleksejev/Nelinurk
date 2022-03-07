using System;
using System.Collections.Generic;
using System.Text;

namespace Nelinurk
{
    class Nelinurk
    {//поля
        string tuup;
        int status;
        double kõrgus;
        double laius;
        public Nelinurk() { }//пустой конструктор 
        public Nelinurk(double Kõrgus, double Laius)//конструктор 
        {
            kõrgus = Kõrgus;
            laius = Laius;
        }
        public string Tuup
        {
            get
            {
                if (kõrgus == laius || status != 90)
                {
                    tuup = "Romb";
                }
                else if (kõrgus == laius || status == 90)
                {
                    tuup = "Ruut";
                }
                else
                {
                    tuup = "Ristkülik";
                }
                return tuup;
            }
        }
        public int Status//Св-во
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
        public void Vastus()//Метод
        {
            Console.WriteLine($"S = {S}"); //площадь
            Console.WriteLine($"P = {P}"); //периметр 
        }
    }
}