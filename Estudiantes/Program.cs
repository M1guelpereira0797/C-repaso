using System.Timers;

Console.WriteLine("Bienvenidos");

Dictionary<string, int> Estudiantes = new Dictionary<string, int>();

Console.WriteLine("Ingrese el bloque de horario en la que el profesor imparte clases: ");
string horario = Console.ReadLine();

switch (horario.ToLower())
{
    case "mañana":
        Console.WriteLine("Ingrese la cantidad de estudaintes que posee en su curso: ");
        int estudianteM = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < estudianteM; i++){
            Console.WriteLine("Ingrese el nombre del estudiante a evaluar:");
            string nombres_estudiante = Console.ReadLine();
            nombres_estudiante = char.ToUpper(nombres_estudiante[0]) + nombres_estudiante.Substring(1).ToLower();
            Console.WriteLine("Ingrese la nota del estudiante a evaluado:");
            int nota_estudiante = Convert.ToInt32(Console.ReadLine());
            Estudiantes.Add(nombres_estudiante, nota_estudiante);
            EvaluarNota(nombres_estudiante, nota_estudiante);

        }
        break;
    case "tarde":
        Console.WriteLine("Ingrese la cantidad de estudaintes que posee en su curso: ");
        int estudianteT = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < estudianteT; i++){
            Console.WriteLine("Ingrese el nombre del estudiante a evaluar:");
            string nombres_estudiante = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del estudiante a evaluado:");
            int nota_estudiante = Convert.ToInt32(Console.ReadLine());
            Estudiantes.Add(nombres_estudiante, nota_estudiante);
            EvaluarNota(nombres_estudiante, nota_estudiante);

        }
        break;
    case "noche":
        Console.WriteLine("Ingrese la cantidad de estudaintes que posee en su curso: ");
        int estudianteN = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < estudianteN; i++){
            Console.WriteLine("Ingrese el nombre del estudiante a evaluar:");
            string nombres_estudiante = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del estudiante a evaluado:");
            int nota_estudiante = Convert.ToInt32(Console.ReadLine());
            Estudiantes.Add(nombres_estudiante, nota_estudiante);

            EvaluarNota(nombres_estudiante, nota_estudiante);
        }
        break;
    default:
        Console.WriteLine("El horario ingresado no esta registrado");
        break;

}

Console.WriteLine("Alumnos y notas ingresadas al sistema. ");
foreach(var item in Estudiantes)
    {
    Console.WriteLine($"Alumno:{item.Key}  Nota: {item.Value}" );
    
}

static void EvaluarNota(string nombres_estudiante, int nota_estudiante){

    if (nota_estudiante <= 4)
    {
        Console.WriteLine("Esta reprobado el alumno " + nombres_estudiante);
    }
    else if (nota_estudiante <= 6)
    {
        Console.WriteLine("Esta aprobado el alumno " + nombres_estudiante);
    }
    else if (nota_estudiante == 7)
    {
        Console.WriteLine("Esta la mejor nota del curso " + nombres_estudiante);
    }
    else
    {
        Console.WriteLine("Ha ingresado mal la nota " + nombres_estudiante);
    }

}