//Ejercicio de puntos

PuntoManejo puntoM = new PuntoManejo(1000);

Console.WriteLine("Ingrese las coordenadas del primer punto:");
Console.Write("X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
puntoM.AñadirPunto(x1, y1);

Console.WriteLine("\nIngrese las coordenadas del segundo punto:");
Console.Write("X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
puntoM.AñadirPunto(x2, y2);

Console.WriteLine("\nPuntos ingresados:");
puntoM.Mostrar();

//Ejercicio de Libros
libroManejo libroM = new libroManejo(2);

Console.WriteLine("Información del libro 1:");
Console.Write("Ingrese el nombre del libro: ");
string titulo1 = Console.ReadLine();
Console.Write("Ingrese el autor: ");
string autor1 = Console.ReadLine();
libroM.AñadirLibro(titulo1, autor1);

Console.WriteLine("\nInformación del libro 2:");
Console.Write("Ingrese el nombre del libro: ");
string titulo2 = Console.ReadLine();
Console.Write("Ingrese el autor: ");
string autor2 = Console.ReadLine();
libroM.AñadirLibro(titulo2, autor2);

Console.WriteLine("\nLibros ingresados:");
libroM.MostrarL();


//Ejercicio Cuadrado
GestorCuadrado gestorCuadrado = new GestorCuadrado();

Console.WriteLine("Ingrese el valor del lado del cuadrado:");
Console.Write("Lado: ");
int lado = Convert.ToInt32(Console.ReadLine());

Cuadrado cuadrado = gestorCuadrado.CrearCuadrado(lado);

Console.WriteLine("\nPerímetro y área del cuadrado:");
gestorCuadrado.MostrarDetallesCuadrado(cuadrado);


