using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    internal class Jugador : Personaje
    {
        public override void Atacar()
        {
            Console.WriteLine($"¡{Nombre} dispara a su enemigo!");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Nombre} se desplaza sigilosamente por el escenario.");
        }
    }
}
