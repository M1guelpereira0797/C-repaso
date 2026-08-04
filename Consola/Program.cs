using System.Diagnostics.CodeAnalysis;

/*Console.WriteLine("Hello, World!");


Console.WriteLine("Ingrese el primer numero que desee sumar: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero que desee sumar: ");
int num2 = int.Parse(Console.ReadLine());

int suma  = num1 + num2;
if(num1 > 0 && num2 >0)
{

    Console.WriteLine("El resultado de la suma es:  " + suma);
}
else
{
    Console.WriteLine("Los numeros ingresado son iguales a 0 o menores a 0 ");
}
*//*
List<int> Numeros = new List<int>();

Console.WriteLine("Ingrese la cantidad de alumnos que desee evaluar: ");
int alumnos = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < alumnos; i++)
{
    Console.WriteLine("Ingrese la nota del alumno: ");
    int nota = Convert.ToInt32(Console.ReadLine());
    Numeros.Add(nota);
}

Console.WriteLine("Notas ingresadas de los alumnos evaluados: ");
foreach(int n in Numeros)
{
    Console.WriteLine(n);
}*/

  Dictionary<string, int> Evaluados =  new Dictionary<string, int>();

Console.WriteLine("Ingrese la cantidad de alumnos que desee evaluar: ");
int alumnos = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < alumnos; i++) { 

    Console.WriteLine("Ingrese el nombre del alumno: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la nota del alumno: ");
    int nota = Convert.ToInt32(Console.ReadLine());
    Evaluados.Add(nombre, nota);
}

Console.WriteLine("Notas ingresadas de los alumnos evaluados: ");
foreach (var n in Evaluados)
{
    Console.WriteLine($"{n.Key} = {n.Value}");
}

Console.ReadKey();