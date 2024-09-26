public class Ejemplo
{
    
    public void Calcularrectangulo()
    {
    
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el alto del rectángulo: ");
        double alto = Convert.ToDouble(Console.ReadLine());

    
        double perimetro = 2 * (ancho + alto);

    
        double area = ancho * alto;

        
        double diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(alto, 2));

        
        Console.WriteLine($"\nPerímetro del rectángulo: {perimetro}");
        Console.WriteLine($"Área del rectángulo: {area}");
        Console.WriteLine($"Diagonal del rectángulo: {diagonal}");
    }
}