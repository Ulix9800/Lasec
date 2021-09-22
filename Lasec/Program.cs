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
