using System;
using System.Collections.Generic;
using System.Text;

namespace Nelinurk
{
    class Nelinurk
    {//поля
        string tuup;
        int status;
        double korgus;
        double laius;
        public Nelinurk() { }//пустой конструктор 
        public Nelinurk(double Korgus, double Laius)//конструктор 
        {
            korgus = Korgus;
            laius = Laius;
        }
        public string Tuup
        {
            get
            {
                if (korgus == laius && status != 90)
                {
                    tuup = "Romb";
                }
                else if (korgus == laius && status == 90)
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
            get { return status; }
            set { }
        }
        public double Pindala()
        {
            double pindala;
            pindala = korgus * laius;
            return pindala;
        }
        public double Perimeeter() // 
        {
            double perimeeter;
            perimeeter = (korgus + laius) * 2;
            return perimeeter;
        }

        public void Vastus()//Метод
        {
            Console.WriteLine("Tuup = {0}",Tuup);//тип
            //Console.WriteLine($"S = {Pindala}"); //площадь
            //Console.WriteLine($"P = {Perimeeter}"); //периметр 
        }
    }
}