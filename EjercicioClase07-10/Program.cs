//Ejercicio 1

List<Coche> coches = new List<Coche>
{
    new Coche("Toyota", "Corolla", 2020, "Estándar", 15000),
    new Coche("Honda", "Civic", 2019, "Manual", 20000),
    new Coche("Ford", "Mustang", 2018, "Estándar", 30000),
    new Coche("Chevrolet", "Camaro", 2021, "Manual", 5000),
    new Coche("Tesla", "Model S", 2022, "Estándar", 1000)
};


Console.WriteLine("Colección de Coches:");
foreach (Coche coche in coches)
    {
        Console.WriteLine(coche);
    }