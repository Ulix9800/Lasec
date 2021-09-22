/*22/09/2021 Presentación de examen para vacante de programador.
Creador del código: José Ulises Domínguez Botello. 
En esta clase se extiende de la clase Animal para crear la clase tortuga, en ella se sobrecarga el método caminar.
Aquí me quedó mucho por hacer, por ejemplo pasar como parametro la distancia de la carrera desde la creación del hilo, 
implementar este backend en una vista*/
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
