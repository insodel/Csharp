using System;

namespace Caesar_Cypher
{                    // En el siglo I a.C., apareció un cifrado por sustitución conocido con el nombre genérico de código César.
                     // Se trata de un cifrado por sustitución.
                     // Como tal, consiste en reasignar a cada letra del abecedario otra nueva resultante de desplazar éste un determinado número de lugares.
                     // Se pide, realizar un programa que encripte un texto mediante el cifrado César.El usuario introducirá el texto, y el número de desplazamiento. (entrada string + entrada int)
                     // Ejemplo:  texto: hola   numero: 2   resultado: jqnc   (h + 2 = j, a + 2 = c, etc..)
                     // Ejemplo2: texto: abcd numero: 1 resultado: bcde
                     // Extra: programar la función encode(string, int) que realiza el proceso inverso
    class Program
    {
        static string Encode(ref string frase, int numDesp) 
        {
            char[] arrayFrase = new char[frase.Length];
            char[] arrayAbecedario = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int z = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                for (int j = 0; j < arrayAbecedario.Length; j++ )
                {
                    if (frase[i] == arrayAbecedario[j])
                    {
                        arrayFrase[z] = arrayAbecedario[j + numDesp];
                        z++;
                    }
                    else continue;
                }               
            }
            frase = new string(arrayFrase);
            return frase;
        }

        static string Decode(ref string frase, int numDesp)
        {
            char[] arrayFrase = new char[frase.Length];
            char[] arrayAbecedario = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int z = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                for (int j = 0; j < arrayAbecedario.Length; j++)
                {
                    if (frase[i] == arrayAbecedario[j])
                    {
                        arrayFrase[z] = arrayAbecedario[j - numDesp];
                        z++;
                    }
                    else continue;
                }
            }
            frase = new string(arrayFrase);
            return frase;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cadena a tratar: ");
            string fraseOg = Console.ReadLine();
            
            Console.WriteLine("Introduzca el número de desplazamiento (debe ser un número entero):");
            int numDesp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Qué operación desea realizar?");
            Console.WriteLine("Presione 1 para codificar el mensaje, 2 para descodificarlo: ");
            int operacion = Convert.ToInt32(Console.ReadLine());

            string frase = fraseOg.ToLower(); 
            
            if (operacion == 1)
            {
                Console.WriteLine(Encode(ref frase, numDesp));
            }
            else if (operacion == 2)
            {
                Console.WriteLine(Decode(ref frase, numDesp));
            }
            else
                Console.WriteLine("Selección de operación errónea.");
        }
    }
}
