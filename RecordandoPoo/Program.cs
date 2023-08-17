// vamos a recordar un poco de poo a ver que tal es que era esto

/*Crear una clase Libro que contenga los siguientes atributos:
 -ISBN
 - Titulo
 - Autor
 - Número de páginas
Crear sus respectivos métodos get y set correspondientes para cada atributo.
Crear el método toString() para mostrar la información relativa al libro con el siguiente formato:
 "El libro su_titulo con ISBN su_ISBN creado por el autor su_autor tiene num_paginas páginas"
En el fichero main, crear 2 objetos Libro (los valores que se quieran) y mostrarlos por pantalla.
Por último, indicar cuál de los 2 tiene más páginas.*/

using programa_1;

Console.WriteLine("Programa 1");

//objetos y le damos los atributos

libro libro1 = new libro(123,"libro1","Rubio",526) ;
libro libro2 = new libro(456, "libro2", "Juan", 852);
libro libro3 = new libro(789, "libro3", "Mejia", 159);


//accedemos al metodo que hemos creado para escribir el libro

Console.WriteLine(libro1.ToString());

//comparamos que libro tiene mas paginas

if (libro1.GetNumPaginas() > libro2.GetNumPaginas()) { Console.WriteLine("El libro 1 tiene mas paginas"); }
else { Console.WriteLine("El libro 2 tiene mas paginas"); }

//probando set

libro1.SetNumPaginas(1024);

Console.WriteLine("El libro 1 tiene "+libro1.GetNumPaginas()+" Paginas" );

//volvemos a comparar
if (libro1.GetNumPaginas() > libro2.GetNumPaginas()) { Console.WriteLine("El libro 1 tiene mas paginas"); }
else { Console.WriteLine("El libro 2 tiene mas paginas"); }