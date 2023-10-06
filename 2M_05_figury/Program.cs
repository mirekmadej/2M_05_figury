using System.Runtime.CompilerServices;
using System.Transactions;

namespace _2M_05_figury
{
    class Trojkat
    {
        private bool czyTrojkat = true;
        private double a = 0, b = 0, c = 0;
        public Trojkat(double a = 0, double b = 0, double c = 0)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
                czyTrojkat = false;               
        }
        private double pole() 
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        private double obwod()
        {
            return a + b + c;
        }
        public override string ToString()
        {
            if (czyTrojkat)
                return $"trójkąt i tu wypisanie pola i obwodu...";
            else
                return "takiego trójkata nie da się zbudować!";
        }
    }
    class Kwadrat
    {
        private double bok = 0;
        public Kwadrat(double bok=0)
        {
            if(bok>0)
                this.bok = bok;
        }
        private double obliczPole()
        {
            return bok * bok;
        }
        public override string ToString()
        {

            return $"Kwadrat o boku {bok}, polu powierzchni {obliczPole()} i obwodzie {4*bok}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kwadrat k1 = new Kwadrat(-2);
            Console.WriteLine(k1);
            Trojkat t1 = new Trojkat(-2, -2, -2);
            Console.WriteLine(t1);
        }
    }
}