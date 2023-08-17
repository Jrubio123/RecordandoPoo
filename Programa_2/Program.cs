/* Implementar una jerarquía de clases para un videojuego, 
    con una clase base 'Personaje' y dos clases derivadas 
    'Jugador' y 'Enemigo'. Cada clase debe tener atributos como 'nombre', 'puntos de vida' y 
    métodos como 'atacar' y 'moverse' con comportamientos específicos para cada tipo de personaje*/
using Programa_2;
using System;

Console.WriteLine("Programa 2");

Jugador jugador1 = new Jugador();

jugador1.Nombre = "Héroe";
jugador1.PuntosVida = 100;

Enemigo enemigo1 = new Enemigo();
enemigo1.Nombre = "Monstruo";
enemigo1.PuntosVida = 50;

jugador1.Atacar();
enemigo1.Atacar();

jugador1.Moverse();
enemigo1.Moverse();
