using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_3
{
    // Enum para representar los colores del automóvil
    public enum ColorAutomovil
    {
        Rojo,
        Azul,
        Verde,
        Negro,
        Blanco,
        Otro
    }
    internal class automovil       
    {
        // Atributos de la clase
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public ColorAutomovil Color { get; set; }//asi llamamos el enum
        public int NumPuertas { get; set; }

        private bool encendido;
        private int marcha;

        // Constructor de la clase
        public automovil(string marca, string modelo, int año, ColorAutomovil color, int numPuertas)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            NumPuertas = numPuertas;

            encendido = false;
            marcha = 0;
        }
        // Método para arrancar el automóvil
        public void Arrancar()
        {
            if (!encendido)
            {
                Console.WriteLine("El automóvil ha arrancado.");
                encendido = true;
            }
            else
            {
                Console.WriteLine("El automóvil ya está encendido.");
            }
        }

        // Método para conducir el automóvil
        public void Conducir()
        {
            if (encendido)
            {
                Console.WriteLine($"El automóvil {Color.ToString().ToLower()} está en movimiento.");
            }
            else
            {
                Console.WriteLine("Primero debes arrancar el automóvil.");
            }
        }

        // Método para cambiar de marcha
        public void CambiarMarcha(int nuevaMarcha)
        {
            if (encendido)
            {
                if (nuevaMarcha<=5 || nuevaMarcha>=-1)
                {
                    if ((nuevaMarcha == marcha + 1) || (nuevaMarcha == marcha - 1))
                    {
                        marcha = nuevaMarcha;
                        Console.WriteLine($"Has cambiado a la marcha {nuevaMarcha}.");
                    }
                    else if (nuevaMarcha == 0) { Console.WriteLine("El vehiculo esta en neutro"); }
                    else if (nuevaMarcha == -1) { Console.WriteLine("Esta dando reversa"); }
                    else { Console.WriteLine("no puedes saltar varias marchas"); }
                }
                else { Console.WriteLine("EL vehiculo no tiene mas marchas"); }               
                
            }
            else
            {
                Console.WriteLine("Primero debes arrancar el automóvil.");
            }
        }

        // Método para apagar el automóvil
        public void Apagar()
        {
            if (encendido)
            {
                Console.WriteLine("El automóvil se ha apagado.");
                encendido = false;
            }
            else
            {
                Console.WriteLine("El automóvil ya está apagado.");
            }
        }


    }

}
