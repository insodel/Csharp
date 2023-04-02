using System;

namespace recursividadFactorial
{
    class Program
    {

        static int Factorial(int n) // función para calcular el factorial de un número entero n
        {
            if (n > 1)              // el cálculo del factorial se realiza de manera regresiva, restando 1 a n en cada iteración de la función
                return n * Factorial(n - 1); // la regresividad dejará de ejecutarse antes de que n valga uno; 
            else                    // si n == 1 o inferior, al tratarse de números que no podemos calcular, devolvemos 1 (el factorial de 1)
                return 1;
        }

        static int Naturales(int salida, int n)
        {                           // esta función nos muestra por pantalla los números desde 1 hasta n (ambos inclusive)
            if (n >= 1)
            {
                n--;
                Console.Write(" {0} ", salida);
                return Naturales(salida + 1, n);
            }
            else
                return salida;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("¿Que operación desea realizar?");
            Console.WriteLine("1 para factorial, 2 para la sucesión de números naturales: ");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Introduzca un número entero: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Factorial(n));
            }
            else
            {
                Console.WriteLine("Introduzca un número entero: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int salida = 1;
                Naturales(salida, n);
            }
            
        }
    }
}
