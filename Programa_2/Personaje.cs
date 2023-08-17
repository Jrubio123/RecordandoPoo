using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    internal class Personaje
    {
        public string Nombre { get; set; }
        public int PuntosVida { get; set; }

        public virtual void Atacar()
        {
            Console.WriteLine($"{Nombre} ataca a su objetivo.");
        }

        public virtual void Moverse()
        {
            Console.WriteLine($"{Nombre} se mueve a una nueva posición.");
        }
    }
}
