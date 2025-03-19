using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intentos = 0;
        int numeroUsuario = 0;

        Console.WriteLine(" Bienvenido a 'Adivina el Número ! ");
        Console.WriteLine(" He pensado en un numero entre 1 y 100. ¿Puedes adivinar cuál es? ");

        while (numeroUsuario != numeroSecreto)
        {
            Console.WriteLine("Ingresa tu numero: ");
            string entrada = Console.ReadLine();

            if(int.TryParse(entrada, out numeroUsuario))
            {
                intentos++;
                if(numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine(" El número es mayor. Intenta otra vez. ");
                }
                else if(numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine(" El número es menor. Intenta otra vez.");
                }
                else
                {
                    Console.WriteLine(" ¡Felicidades! Has adivinado el número {numeroSecreto} en {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine(" Entrada no válida. Por favor, ingresa un número entero.");
            }
        }
    }
}
