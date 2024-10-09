
//List<Person> Persons = new List<Person>();

//List<int> numbers = new List<int>();


List<Person> people = new List<Person>
    {
        new Person { Name = "Osvado", LastName = "Ramirez", BirthOfDate= new DateTime(2004,12,20)},
        new Person { Name = "Manuel", LastName = "Ramirez", BirthOfDate= new DateTime(2004,12,20)},
        new Person { Name = "Osvado", LastName = "Ramirez", BirthOfDate= new DateTime(2004,12,20)},
        new Person { Name = "Osvado", LastName = "Ramirez", BirthOfDate= new DateTime(2004,12,20)},
        new Person { Name = "Osvado", LastName = "Ramirez", BirthOfDate= new DateTime(2004,12,20)}
        
    };

people.Add(new Person(){ Name = "Valo", LastName = "Ramirez", BirthOfDate = new DateTime(2004,12,20)} );

/*
    foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name} {person.LastName}, Born: {person.BirthOfDate.ToShortDateString()}");
        }

var found = people.Where(x=>x.Name =="John").FirstOrDefault();

     Console.WriteLine($"Name: {found.Name} {found.LastName}, Born: {found.BirthOfDate.ToShortDateString()}");

*/

var chivas = new Team();
chivas.Name = "Glorioso club deportivo guadalajara";
chivas.Players = new List<Person>();

Person person1 = new Person();
person1.Name ="Piojo";
person1.LastName ="Alvarado";
person1.BirthOfDate = DateTime.Today.AddYears(-20);

Person person2 = new Person();
person2.Name ="Victor";
person2.LastName ="Guzman";
person2.BirthOfDate = DateTime.Today.AddYears(-25);

chivas.Players.Add(person1);
chivas.Players.Add(person2);

chivas.Players.AddRange(people);

    foreach (var person in chivas.Players)
        {
            Console.WriteLine($"Name: {person.Name} {person.LastName}, Born: {person.BirthOfDate.ToShortDateString()}");
        }

Dictionary<int, Person> playersForTheMatch = new Dictionary<int, Person>();

playersForTheMatch.TryAdd(1, person1);
playersForTheMatch.TryAdd(2, person2);

int mes = 1;
string mensaje = "mensaje a enviar";

if(mes ==1)
    mensaje = "Mensaje de enero";
if(mes ==2)
    mensaje = "Mensaje de febrero";
if(mes ==3)
    mensaje = "Mensaje de marzo";
if(mes ==4)
    mensaje = "Mensaje de abril";
if(mes ==5)
    mensaje = "Mensaje de mayo";
if(mes ==6)
    mensaje = "Mensaje de julio";
if(mes ==7)
    mensaje = "Mensaje de junio";
if(mes ==8)
    mensaje = "Mensaje de agosto";
if(mes ==9)
    mensaje = "Mensaje de septiembre";
if(mes ==10)
    mensaje = "Mensaje de octubre";
if(mes ==11)
    mensaje = "Mensaje de noviembre";
if(mes ==12)
    mensaje = "Mensaje de diciembre";

Dictionary<int, string> mensajes = new Dictionary<int, string>();

mensajes.TryAdd(1, "Mensaje de enero");
mensajes.TryAdd(2, "Mensaje de febrero");
mensajes.TryAdd(3, "Mensaje de marzo");

if(mensajes.TryGetValue(2, out string mensajeActual) == true)
{
    Console.WriteLine(mensajeActual);
}


