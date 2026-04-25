// Muestra el mensaje en la consola
Console.WriteLine("Ingrese primer numero:");
double n1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese primer numero:");
double n2 = double.Parse(Console.ReadLine() ?? "0");

double division = n1 / n2;

Console.WriteLine($"La division de {n1} y {n2} es: {division}");
//Console.WriteLine("La division de " + n1 + " y " + n2 + "es: " + division);