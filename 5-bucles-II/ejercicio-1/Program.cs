System.Console.Clear();
System.Console.WriteLine("### 5 BUCLES II - EJERCICIO 1 ###\n");
System.Console.WriteLine("Ingrese su nombre: ");
string name = Console.ReadLine();
System.Console.WriteLine("Ingrese su email: ");
string email = Console.ReadLine();
System.Console.WriteLine("¿Posée cupon? (Sí | No): ");
string cupon = Console.ReadLine();

System.Console.WriteLine("\nEl costo de su producto es de 100$.");
if (cupon == "Sí" || cupon == "Si" || cupon == "sí" || cupon == "si") {
  System.Console.WriteLine("Descuento de cupón 50%");
  System.Console.WriteLine("Total a pagar: 50$");
} else if (cupon == "No" || cupon == "no") {
  System.Console.WriteLine("--- Total a pagar: 100$ ---");
}