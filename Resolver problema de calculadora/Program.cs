// Resolver problema de Calculadora.

//Calcular la suma de dos numeros.
//Pedir y leer dos numeros ingresados por el usuario.
//Moostrar el resultado en pantalla */

int Numero1;
int Numero2;
int Resultado;

Console.WriteLine("Ingrese el primer numero");
Numero1= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
Numero2 = int.Parse(Console.ReadLine());

Resultado = Numero1 + Numero2;
Console.WriteLine(Resultado);