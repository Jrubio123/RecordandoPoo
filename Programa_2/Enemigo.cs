using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    internal class Enemigo : Personaje
    {
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} embiste a su oponente con ferocidad.");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Nombre} se mueve en patrones impredecibles.");
        }
    }
}
