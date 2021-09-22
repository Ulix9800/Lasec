/*22/09/2021 Presentación de examen para vacante de programador.
Creador del código: José Ulises Domínguez Botello 
En esta clase se extiende de la clase Animal para crear la clase Liebre, en ella se generan los métodos correr y descansar.
Aquí me quedó mucho por hacer, por ejemplo pasar como parametro la distancia de la carrera desde la creación del hilo, 
poner más descansos y quizá que la liebre se regresara al no ver a la tortuga y por supuesto implementar este backend en una vista*/
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
                if (I == 9)
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
