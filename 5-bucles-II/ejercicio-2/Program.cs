System.Console.Clear();
System.Console.WriteLine("### Bucles II - Ejercicio 2 ###\n");
System.Console.WriteLine("Por favor ingresa una opción");
System.Console.WriteLine("1) C#");
System.Console.WriteLine("2) Java");
System.Console.WriteLine("3) Python");
System.Console.WriteLine("4) Javascript");
System.Console.WriteLine("5) Typescript");
System.Console.Write("\nIngrese su opción: ");
string option = Console.ReadLine();
System.Console.WriteLine();

switch (option) {
  case "1":
    System.Console.WriteLine("Usted seleccionó C#.");
    break;

  case "2":
    System.Console.WriteLine("Usted seleccionó Java.");
    break;

  case "3":
    System.Console.WriteLine("Usted seleccionó Python.");
    break;

  case "4":
    System.Console.WriteLine("Usted seleccionó Javascript.");
    break;

  case "5":
    System.Console.WriteLine("Usted seleccionó Typescript.");
    break;
}
