using System;

namespace EjerClase11._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = 1;
            int N2 = 2;
            int X;

            X = N1 + N2;
            Console.WriteLine("El resultado de la suma es: " + X);
            X = N1 - N2;
            Console.WriteLine("El resultado de la resta es: " + X);
            X = N1 * N2;
            Console.WriteLine("El resultado de la multiplicacion es: " + X);
            X = N1 / N2;
            Console.WriteLine("El resultado de la division es: " + X);

            readonly string[] personas = new string[4] { "Eugenio", "Emma", "Lorenzo", "Ricardo", "Veronica" };

            foreach (int nombres in personas)
            {
                Console.WriteLine(nombres);
            }   
    
    }
}
