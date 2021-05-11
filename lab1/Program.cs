using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Деление комплексных чисел";
            Complex a = new Complex(), b = new Complex();
            double a1 = 0, b1 = 0, a2 = 0, b2 = 0;
            bool flag;
            string strg = "";
            while (true)
            {
                Console.Clear();
                flag = true;
               // Console.WriteLine("Вершина 1");
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("----------------------------------Деление комплексных чисел------------------------------------\n" +
                        "Программа выполняет деление двух комплексных чисел:\n" +
                        "z1 = a1 + b1*i (делимое) и z2 = a2 + b2*i (делитель).\n" +
                        "Примечание:\nПрограмма обрабатывает 154 - разрядные числа.\n" +
                        "Макс. число символов, которое можно ввести с клавиатуры, - 254.\n" +
                        "При вводе десятичных дробей в качестве разделителя целой и дробной части используется запятая.\n" +
                        "Входные данные:"
                        );

                        Console.Write("a1 = ");
                        string str = Console.ReadLine();
                        a1 = Convert.ToDouble(str);

                        Console.Write("b1 = ");
                        str = Console.ReadLine();
                        b1 = Convert.ToDouble(str);

                        Console.Write("a2 = ");
                        str = Console.ReadLine();
                        a2 = Convert.ToDouble(str);

                        Console.Write("b2 = ");
                        str = Console.ReadLine();
                        b2 = Convert.ToDouble(str);

                        flag = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный формат данных!");
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                    }
                }

                Console.WriteLine($"Получены следующие комплексные числа:\nz1 = {a1} + ({b1})*i");
                Console.WriteLine($"z2 = {a2} + ({b2})*i");

               // Console.WriteLine("Вершина 2");

                a.Real = a1; a.Imag = b1;
                b.Real = a2; b.Imag = b2;

               // Console.WriteLine("Вершина 3");

                strg = Complex.div(a, b);
                Console.WriteLine(strg);

                Console.WriteLine("Нажмите <п>, чтобы продолжить, или <Ctrl + C>, чтобы закрыть программу.");
               // Console.WriteLine("Вершина 26");
                string ch = Console.ReadLine();
              //  Console.WriteLine("Вершина 27");
                if (ch != "п")
                {
               //     Console.WriteLine("Вершина 28");
                    Environment.Exit(0);
                }
              //  Console.WriteLine("Вершина 29");
            }
        }
    }
}
