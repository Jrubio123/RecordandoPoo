/*Crea una clase para representar un automóvil. 
La clase debe tener atributos para la marca, 
modelo, el año, el color y el número de puertas.
También debe tener métodos para arrancar el automóvil
conducir el automóvil, apagar el automóvil y cambiar de marcha.*/
using programa_3;

Console.WriteLine("Programa 3");

automovil carro1 = new automovil("kia", "Sportage", 2016, ColorAutomovil.Rojo, 4);

carro1.Arrancar();
carro1.Conducir();
carro1.CambiarMarcha(1);
carro1.CambiarMarcha(2);
carro1.CambiarMarcha(1);
carro1.CambiarMarcha(1);
carro1.CambiarMarcha(-1);

carro1.Apagar();
Console.ReadLine();