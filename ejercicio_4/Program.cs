Console.WriteLine("Hola, por favor ingrese las notas de los estudiantes");
Console.WriteLine("Tenga en cuenta que si va a ingresar un dato decimal, debe ingrear la notación con coma (,)");

Console.WriteLine("Nota 1: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Nota 2: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Nota 3: ");
double nota3 = double.Parse(Console.ReadLine());

double porcentaje1 = nota1 * 0.20;
double porcentaje2 = nota2 * 0.30;
double porcentaje3 = nota3 * 0.50;

double definitiva = porcentaje1 + porcentaje2 + porcentaje3;
Console.WriteLine("La nota definitiva es: " + definitiva);
