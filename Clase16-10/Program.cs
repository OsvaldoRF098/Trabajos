// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Student student = new Student("Osvaldo", "Ramirez");

Console.WriteLine($"{student.LastName} {student.Name}");

Student student2 = new Student("Manuel", "Flores");

if(student==student2)
    Console.WriteLine("Registro duplicado");
else
    Console.WriteLine("No son iguales");



StudentClass studentc = new StudentClass();
studentc.Name = "Osvaldo";
studentc.LastName = "Ramirez";

Console.WriteLine($"{studentc.LastName} {studentc.Name}");


StudentClass studentc2 = new StudentClass();
studentc2.Name = "Osvaldo";
studentc2.LastName = "Ramirez";

if(studentc==studentc2)
    Console.WriteLine("Registro duplicado");
else
    Console.WriteLine("No son iguales");

Console.WriteLine(studentc.ToString());

Student GetSudent (string name, string lastname)
{
    return new Student(name, lastname);
}
