// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Creando una instancia de Persona
Persona persona = new Persona();
persona.Saludar();

// Creando una instancia de Estudiante
Estudiante estudiante = new Estudiante();
estudiante.EstablecerEdad(21);
estudiante.Saludar();
estudiante.MostrarEdad();
estudiante.IrAClases();

// Creando una instancia de Profesor
Profesor profesor = new Profesor();
profesor.EstablecerEdad(30);
profesor.Saludar();
profesor.Explicar();
    
