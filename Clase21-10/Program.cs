using System.Runtime.CompilerServices;

int intNunNull = 0;


Console.Write(intNunNull);

int? intNullable = null;

Console.WriteLine(intNullable);

string? name = "Valor X";

string displayName = name??"uknown name";

Console.WriteLine(displayName);

Person? person = null;

var newPerson = person?? new Person();

Console.WriteLine("Se creo un nuevo objeto");

Person customer = null;
string nameCustomer = customer?.Name;

Console.WriteLine("Aqui termino");

Console.WriteLine(nameCustomer);

if(customer is null)
    Console.WriteLine("el customer no trae datos");

string? notNUllString = "some value";

Console.WriteLine(notNUllString);

try
{
    ValidateNull(null);
}
catch(ArgumentNullException)
{
    Console.WriteLine("Error de nulo");
}

void ValidateNull (string parameter)
{
    ArgumentNullException.ThrowIfNull(parameter);
}





