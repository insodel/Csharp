using System;

namespace ConsoleApp79
{
    class Program
    {
        /// <summary>
        /// Función que guarda la frase introducida por el usuario en la variable frase.
        /// </summary>
        /// <returns>frase</returns>
        static string EntradaDatos()
        {
            Console.WriteLine("Introduzca una frase: ");
            string frase = Console.ReadLine();
            return frase;
        }
        /// <summary>
        /// Función que toma la frase previamente definida y la transforma en minúsculas y elimina los espacios.
        /// </summary>
        /// <param name="frase"></param>
        /// <returns>fraseMinus</returns>
        static string FraseMinusc(ref string frase)
        {
            frase.ToLower();
            string fraseMinus = frase.Replace(" ", "");
            return fraseMinus;
        }
        /// <summary>
        /// Función que crea una nueva variable tras invertir el orden de la frase en minúsculas.
        /// </summary>
        /// <param name="frase"></param>
        /// <returns>fraseInvertida</returns>
        static string InvertirFrase(string frase)
        {
           
            char[] array = frase.ToCharArray();
            Array.Reverse(array);
            string fraseInvertida = new string (array);
            return fraseInvertida;
        }
        /// <summary>
        /// Función que comprueba si la frase invertida y la frase original son iguales. En caso de serlo, la frase es un palíndromo.
        /// </summary>
        /// <param name="fraseInvertida"></param>
        /// <param name="frase"></param>
        /// <returns>True si es palíndromo, False si no lo es.</returns>
        static bool ComprobarPalindromo(string fraseInvertida, string frase)
        {
            if (fraseInvertida == frase)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            string frase = EntradaDatos();
            frase = FraseMinusc(ref frase);
            string fraseInvertida = InvertirFrase(frase);
            
            if (ComprobarPalindromo(frase, fraseInvertida) == true)
                Console.WriteLine("Es palíndromo.");
            else
                Console.WriteLine("No es palíndromo.");
                  
        }           
    }
}
