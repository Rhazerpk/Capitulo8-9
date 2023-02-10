using System;

namespace Capitulo8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Cap9 ej = new Cap9();
            Ejercicios ej1 = new Ejercicios();

            do
            {

                Console.Write("\n -----------MENU-----------\n\n");
                Console.Write("\n ---Selecciona una opcion:\n");
                Console.Write("\n 1) Capitulo # 8 Ejercicio 3 ");
                Console.Write("\n 2) Capitulo # 8 Ejercicio 5 ");
                Console.Write("\n 3) Capitulo # 9");
                Console.Write("\n 4) Salir\n\n ");

                opcion = Int16.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        ej1.Cap8_ej3();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escribe letras al azar y se ordenara alfabeticamente\n");
                        ej1.Cap8_ej5();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        ej.ShowUp();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el programa, vuelva pronto :)");
                        break;
                        
                }

            } while (opcion != 4);
        }
    }
}
