/*22/09/2021 Presentación de examen para vacante de programador.
Creador del código: José Ulises Domínguez Botello 
En esta clase se relizan las instancias de clase y la creación de multihilo para 
que el avance de la tortuga como de la liebre se ejecute al mismo tiempo*/
using System;
using System.Threading;

namespace Lasec
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Tortuga tortuga = new Tortuga();
            Liebre liebre = new Liebre();

            Thread hiloLiebre = new Thread(liebre.correr);
            Thread hiloTortuga = new Thread(tortuga.caminar);
            hiloLiebre.Start();
            hiloTortuga.Start();
            

        }
    }
}
