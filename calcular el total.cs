using System;

namespace suma_por_el_usuario
{
    class Program
    {
        static void Main(string[] args)
        {//declaracion de variavle 
            int miNumero;
            int suma = 0;
            
            do
            {
                Console.WriteLine("introduzca una cantidada de nuemeros limitada");
                miNumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el nuemero dijitado es :" + miNumero);
                suma = suma + miNumero;
                

            }
            while (miNumero != 0);
            Console.WriteLine("la sumatoria total es: " + suma);
           


        }
    }
}
