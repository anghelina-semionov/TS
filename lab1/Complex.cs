using System;

namespace lab1
{
    class Complex
    {
        private double real;
        private double imag;

        public double Real
        {
            get { return real; }
            set { real = value; }
        }
        public double Imag
        {
            get { return imag; }
            set { imag = value; }
        }

        public static string div(Complex a, Complex b)
        {
            //Console.WriteLine("Вершина 4");
            //Console.WriteLine("Вершина 5");
            double a1 = a.real;
            double b1 = a.imag;
            double a2 = b.real;
            double b2 = b.imag;

            Complex res = new Complex();

            double den = a2 * a2 + b2 * b2;

           // Console.WriteLine("Вершина 6");
            if (Double.IsInfinity(den))
            {
                //Console.WriteLine("Вершина 7");
                //Console.WriteLine("Переполнение: невозможно выполнить деление.");
                return "Переполнение: невозможно выполнить деление.";
                //throw new ArithmeticException();
                // Console.WriteLine("Вершина 8");
            }
            //Console.WriteLine("Вершина 9");
            //if (den == 0)
            //{
            ////    Console.WriteLine("Вершина 10");
            //    //Console.WriteLine("Попытка деления на нуль!");
            //    return "Попытка деления на нуль!";
            //    //Console.WriteLine("Вершина 11");
            //}

            res.real = (a1 * a2 + b1 * b2) / den;
            res.imag = (a2 * b1 - a1 * b2) / den;

            //Console.WriteLine("Вершина 12");

            //Console.WriteLine("Вершина 13");
            if (res.real == 0 && res.imag != 0)
            {
                //Console.WriteLine("Вершина 14, 15");
                //Console.WriteLine($"Результат деления: z = {res.imag}*i");
                return "Результат деления: z = " + res.imag.ToString() + "*i" ;
               // Console.WriteLine("Вершина 16");
            }
            //Console.WriteLine("Вершина 17");
            if (res.real != 0 && res.imag == 0)
            {
                //Console.WriteLine("Вершина 18, 19");
               // Console.WriteLine($"Результат деления: z = {res.real}");
                return "Результат деления: z = " + res.real.ToString() + "*i"; ;
                //Console.WriteLine("Вершина 20");
            }
            //Console.WriteLine("Вершина 21");
            if (res.real == 0 && res.imag == 0)
            {
               // Console.WriteLine("Вершина 22, 23");
               // Console.WriteLine("z = 0");
                return "Результат деления: z = 0";
                //Console.WriteLine("Вершина 24");
            }
            return "Результат деления: z = " + res.real.ToString() + " + (" + res.imag.ToString() + ")*i";
            //Console.WriteLine($"Результат деления: z = {res.real} + ({res.imag})*i");
            //Console.WriteLine("Вершина 25");
        }
    }
}
