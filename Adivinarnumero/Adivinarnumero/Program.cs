using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinarnumero
{
    class Program
    {
        static void Main(string[] args)
        {   
            int respuesta1;
            // Generamos una instalcia para poder asignar números aletorios entre 0 y 100.
            Random random = new Random();
            int numeroaleatorio = random.Next(0, 100);

            inicializar();
            

            void inicializar()
            {
                Console.WriteLine("¡HOLA!, Vamos a jugar a un juego. Intenta adivinar que número estoy pensando. Para ello voy a darte solamente CUATRO oportunidades y varias pistas; la primera es que se cuentra entre los números 0 y 100...");
                Console.WriteLine($"Test {numeroaleatorio}");//Se coloca un test para poder ver el número generado por la máquina.
                Console.ReadKey();

                //Hacemos que cada vez que de una respuesta erronea repita el bucle hasta 5 veces. Una vez que se ha intenado esas veces se cierra. 

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Inserta número a adivinar");
                    respuesta1 = int.Parse(Console.ReadLine());

                    if (respuesta1 == numeroaleatorio)
                    {
                        Console.WriteLine("Enhorabuena, has acertado");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Has fallado, intentalo de nuevo");
                        
                        
                    }
                    
                }
            }
           
        }
    }
}