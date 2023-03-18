// Ejercicio 3 - For
// Escribe un programa que realice estos pasos:
// Reciba 3 datos:
// - ancho
// - alto
// - relleno o no
// Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
// En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
// Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:
// Input: 2,2,2, relleno = true
// Output:
// ** **
// ** **
// Input: 3, 4, 1, relleno = false
// Output:
// ***
// * *
// * *
// ***

System.Console.WriteLine("Ingrese el ancho: ");
string? ancho = Console.ReadLine();
System.Console.WriteLine("Ingrese el alto: ");
string? alto = Console.ReadLine();
System.Console.WriteLine("¿Tiene relleno? (0 = No | 1 = Sí): ");
string? relleno = Console.ReadLine();

int anchoInt = int.Parse(ancho);
int altoInt= int.Parse(alto);

if (relleno == "1") {
  for (int i = 0; i < altoInt; i++) {
    for(int j = 0; j < anchoInt; j++) {
      System.Console.Write("*");
    }
    System.Console.Write("\n");
  }
} else {
  for (int i = 0; i < altoInt; i++) {
    if (i == 0 || i == altoInt - 1) {
      for (int j = 0; j < anchoInt; j++) {
        System.Console.Write("*");
      }
      System.Console.Write("\n");
    } else {
      for (int j = 0; j < anchoInt; j++) {
        if (j == 0 || j == anchoInt - 1) {
          System.Console.Write("*");
        } else {
          System.Console.Write(" ");
        }
      }
      System.Console.Write("\n");
    }
  }
}