
Point Punto1 = new Point();
Point Punto2 = new Point();

Console.WriteLine("Ingresa punto 1:");
Punto1 = LeerPunto();

Console.WriteLine("Ingresa punto  2:");
Punto2 = LeerPunto();

Console.WriteLine("Punto 1:");
Punto1.D();

Console.WriteLine("Punto 2");
Punto2.D();


static Point LeerPunto()
{
    Point punto = new Point();

    Console.Write("Ingresa Cordenada X (short): ");
    punto.X = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingresa Cordenada Y (short): ");
    punto.Y = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingresa valor Red (byte): ");
    punto.R = Convert.ToByte(Console.ReadLine());

    Console.Write("Ingresa valor Green (byte): ");
    punto.G = Convert.ToByte(Console.ReadLine());

    Console.Write("Ingresa valor Blue (byte): ");
    punto.B = Convert.ToByte(Console.ReadLine());

    return punto;
}

