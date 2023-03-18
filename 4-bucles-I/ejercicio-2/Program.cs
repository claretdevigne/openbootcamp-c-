// Ejercicio 2 - Do while
// Escribe un programa que realice estos pasos:
// - Reciba al menos un número por consola
// - Determine si el número es positivo o negativo
// - Presente un contador para cada tipo (positivo y negativo).
// Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
// Tienes completa libertad para elegir el formato de la salida.

Contador counter = new Contador(0, 0);

do
{
  System.Console.Clear();
  System.Console.WriteLine("###### Verificador de positivos y negativos ######\n");
  System.Console.WriteLine($"Positivos: { counter.positivos }");
  System.Console.WriteLine($"Negativos: { counter.negativos }\n");
  System.Console.WriteLine("Ingrese un número entero | Escriba Exit para salir");

  string? input = Console.ReadLine();
  
  if (input == "Exit")
  {
    break;
  }

  int number = int.Parse(input);

  if ( number > 0 ) {
    counter.positivos += 1;
    System.Console.WriteLine($"\nEl número { number } es positivo.");
    System.Console.Clear();
  } else if (number < 0) {
      counter.negativos += 1;
      System.Console.WriteLine($"\nEl número { number } es negativo.");
      System.Console.Clear();
  }
} while (true);

public struct Contador {

  public Contador(int Positivos, int Negativos) {
    positivos = Positivos;
    negativos = Negativos;
  }

  public int positivos { get; set; }

  public int negativos { get; set; }
}