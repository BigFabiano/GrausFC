using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converta uma temperatura digitada pelo usuário em °F para °C.
            //°C = (°F − 32) / 1,8
            Console.Clear();
            double doubleF;
            double doubleC;
            Console.WriteLine(" --- Vamos converter a temperatura Fahrenheit para Celsius ---");
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");  
            Console.Write(" Informe a temperatura em Fahrenheit: º ");
            doubleF = Convert.ToDouble(Console.ReadLine());
            doubleC = (doubleF - 32) / 1.8;
            Console.WriteLine($" A temperatura de ºF {doubleF} , corresponde a {doubleC:N2}");
        }
    }
}
