using System;
using System.Collections.Generic;
using System.Text;

namespace Lasec
{
    public class Tortuga : Animal
    {
        public override void caminar()
        {
            int distanciaCarrera = 10;
            Console.WriteLine("La distancia total de la carrera es " + distanciaCarrera + " metros");
            for (int J = 0; J <= distanciaCarrera; J++)
            {
                Console.WriteLine("La tortuga ha recorrido la distancia de : {0}", J);
            }
        }
    }    
}
