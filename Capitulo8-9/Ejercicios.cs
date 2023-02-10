using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo8_9
{
    class Ejercicios
    {
        public void Cap8_ej3()
        {
            DateTime hora = DateTime.Now;
            Console.WriteLine("La hora es: " + hora.ToString("h:mm:ss AM/PM"));
            Console.WriteLine(" \n La fecha es: " + hora.ToLongDateString());
        }

        public void Cap8_ej5()
        {
            char datos;
            string Cadena = Console.ReadLine();
            string Data = Cadena.ToLower();
            char[] letra = Data.ToCharArray();

            for (int i = 1; i < letra.Length; i++)
            {
                for (int j = 0; j < letra.Length - 1; j++)
                {
                    if (letra[j] > letra[j + 1])
                    {
                        datos = letra[j];
                        letra[j] = letra[j + 1];
                        letra[j + 1] = datos;
                    }
                }
            }
            Console.WriteLine(letra);
            Console.ReadLine();
        }
    }
}
