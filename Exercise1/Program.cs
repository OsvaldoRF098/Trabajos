// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");
Console.WriteLine("Por favor introduzca su nombre");
int numeroPersonas= 12;
string? NombrePersona= Console.ReadLine();
Console.WriteLine("En este salon hay {0} personas y una se llama {1}",numeroPersonas,NombrePersona);

//Tareas de Clase 23 de sep
Tarea tarea = new Tarea();
tarea.ejerciciostarea();

//Ejercicio de clase 25 de sep

// cast implicit 
Console.WriteLine("cast!");
int valor = 2147483647;
long number = valor; 
Console.WriteLine(number);

//cast emplicit
double x = 4_294_967_295;
int a;
a = (int)x;
Console.WriteLine(x);

Contador contador = new Contador();
contador.GetNextValue();

Ejemplo ejemplo = new Ejemplo();
ejemplo.Calcularrectangulo();