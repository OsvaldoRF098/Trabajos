// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine(ToString("Osvaldo","Ramirez"));


//Console.WriteLine(ToString2("Osvaldo","Ramirez"));

string ToString(string name, string lastname, string id)
{
    return $"{id} {name} {lastname}";
}


string ToString2(string name, string lastname) => $"{name} {lastname}";


Employee [] employees = new Employee[10];

for(var x=0; x<5; x++)
{
    Console.WriteLine("Escribe el nombre");
    employees[x].EmpId = x;
    employees[x].FirstName = Console.ReadLine();

    Console.WriteLine("Escribe el Apellido");
    employees[x].LastName = Console.ReadLine();

    employees[x].Position= PositionType.GoalKeeper;

    employees[x].WondersVisited = WonderOfTheAncientWorld.ColossusOfRhodes | WonderOfTheAncientWorld.HangingGardensOfBabylon;
}

Console.WriteLine("Imprimir lista de empreados");

for(var x=0; x<5; x++)
{
    Console.WriteLine(x);
    employees[x].Print();
}