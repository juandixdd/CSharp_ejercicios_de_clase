Console.WriteLine("Hola, por favor ingrese 2 números ");

Console.WriteLine("Número 1: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Número 2: ");
double num2 = double.Parse(Console.ReadLine());

double suma = num1 + num2;
double resta = num1 - num2;
double multiplicacion = num1 * num2;
double division = num1 / num2;

Console.WriteLine("Resultados");
Console.WriteLine("");
Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + division);