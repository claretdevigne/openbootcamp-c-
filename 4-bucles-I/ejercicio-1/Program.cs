// Ejercicio 1 - While
// Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 
// Es decir, un programa que presente para el 1:
// 1 x 1 = 1
// 1 x 2 = 2
// …
// 1 x 10 = 10

int i = 1;
System.Console.WriteLine("--- TABLA DEL 1 ---");
while ( i <= 10 )
{
  System.Console.WriteLine($"1 x { i } = { 1 * i }");
  i++;
}