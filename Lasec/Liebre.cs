using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lasec
{
    public class Liebre: Animal
    {
        public void correr()
        {
            int distanciaCarrera = 10;
            Console.WriteLine("La distancia total de la carrera es " + distanciaCarrera + " metros");
            for (int I = 0; I <= distanciaCarrera; I++)
            {
                Console.WriteLine("La liebre ha recorrido la distancia de : {0}", I);
                if (I == 8)
                {
                    descansar(6000);
                }
            }
        }
    
        public int descansar(int milisegundos)
        {
            Thread.Sleep(milisegundos);
            Console.WriteLine("La liebre se puso a descansar");
            return milisegundos;
        }
    }
}
