try{
    // Muestra el mensaje en la consola
    /*Console.WriteLine("Ingrese primer numero:");
    double n1 = double.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Ingrese primer numero:");
    double n2 = double.Parse(Console.ReadLine() ?? "0");

    double division = n1 / n2;

    Console.WriteLine($"La division de {n1} y {n2} es: {division}");*/
    //Console.WriteLine("La division de " + n1 + " y " + n2 + "es: " + division);

    /*List<string> frutas = new List<string>();
    frutas.Add("Manzana");
    frutas.Add("Banana");
    frutas.Add("Naranja");
    frutas.Add("Uva");
    //frutas.Add("");
    frutas.Insert(0, "Pera");
    frutas.Remove("Manzana");

    foreach (string fruta in frutas)
    {
        Console.WriteLine(fruta);
    }*/
    
    

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Ocurrio un error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error: " + ex.Message);
}