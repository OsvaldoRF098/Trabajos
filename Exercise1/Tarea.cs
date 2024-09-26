public class Tarea
{
    public void ejerciciostarea()
    {
        // obtener el valor absoluto de la diferencia entre dos números dados. Devuelve el doble del valor absoluto de la diferencia si el primer número es mayor que el segundo número.
        Console.WriteLine("Ingrese el primer numero:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");    
        int num2 = int.Parse(Console.ReadLine());

        int difference = Math.Abs(num1 - num2);
        
        if (num1 > num2)
            {
                difference *= 2;
            }
        Console.WriteLine("El resultado es: " + difference);
        //imprime los numeros impares del 1 al 99, imprime numero por linea

        for (int i = 1; i <= 99; i += 2)
            {
                Console.WriteLine(i);
            }

    }
}