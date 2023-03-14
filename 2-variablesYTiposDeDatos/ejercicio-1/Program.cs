System.Console.WriteLine("Ingrese su nombre: ");
string? name = Console.ReadLine();
System.Console.WriteLine("Ingrese su apellido: ");
string? apellido = Console.ReadLine();
System.Console.WriteLine("Ingrese su edad: ");
string? edad = Console.ReadLine();
System.Console.WriteLine("¿Sabe programar (sí - no)?: ");
string? programa = Console.ReadLine();

string mensaje = "Hola, " + name + " " + apellido + ". Tienes " + edad + " años y " + programa + " sabes programar.";

System.Console.WriteLine(mensaje);