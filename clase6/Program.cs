// See https://aka.ms/new-console-template for more information

using Estructuras; //ES COMO IMPORTAR
class Program
{
    static void Main()

    {
        List<Cursos> cursos = new List<Cursos>();

        string NombreCurso = "";
        int DuracionSemanaCurso = 0;
        int PrecioCurso = 0;
        string Salir = "";

        do
        {
            //INPUTS
            Console.WriteLine("Escirbe el nombre del Curso: ");
            NombreCurso = Console.ReadLine();

            Console.WriteLine("Escirbe la duración del Curso: ");
            DuracionSemanaCurso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escirbe el precio del Curso: ");
            PrecioCurso = Convert.ToInt32(Console.ReadLine());

            Cursos curso= new Cursos(NombreCurso,DuracionSemanaCurso,PrecioCurso); 
            cursos.Add(curso);

            Console.WriteLine("Si Desea Salir escriba s, si desea continuar escriba cualquier letra");
            Salir= Console.ReadLine();

        } while (Salir.ToUpper()!= "S");

        foreach (var item in cursos)
        {
            item.informacionCurso();
        }

        //Cursos curso1= new Cursos("JavaScript",20,1800);
        //Console.WriteLine($"El curso de {curso1.Nombre} con una duración de {curso1.DuracionSemanas} semanas tiene" +
        //    $" un precio de {curso1.Precio} soles");

        //Cursos curso2 = new Cursos("Java", 10, 1400);
        //curso2.informacionCurso();
        /*
        List<Empleado> empleados = new List<Empleado>();

        string Salir = "";
        string? Nombres = "";// ? PUEDE SER NULLABLE
        int Salario = 0;
        string Departamento = "";

        //null es diferente a vacío ""
        do
        {
            Console.WriteLine("Ingresa el nombre del empleado:");
            Nombres = Console.ReadLine();
            Console.WriteLine("Ingresa el salario del empleado:");
            Salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el área del empleado:");
            Departamento = Console.ReadLine();

            // Estudiante estudiante = new Estudiante("Hugo",36,20);

            Empleado empleado = new Empleado(Nombres, Salario, Departamento);

            empleados.Add(empleado);

            Console.WriteLine("Desea Salir");
            Salir = Console.ReadLine();

        } while (Salir.ToUpper() != "S");

        foreach (var item in empleados )
        {
            Console.WriteLine($"Nombres: {item.Nombre} Salario: {item.Salario} Departamento:{item.Departamento} ");
        }

        */
        ///

        /*
        List<Estudiante> estudiantes= new List<Estudiante>();

        string Salir = "";
        string? Nombres = "";// ? PUEDE SER NULLABLE
        int Edad = 0;
        int Calificacion = 0;

        //null es diferente a vacío ""
        do
        {
            Console.WriteLine("Ingresa el nombre del estudiante:");
            Nombres = Console.ReadLine();
            Console.WriteLine("Ingresa la edad del estudiante:");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la calificación del estudiante:");
            Calificacion = Convert.ToInt32(Console.ReadLine());

            // Estudiante estudiante = new Estudiante("Hugo",36,20);

            Estudiante estudiante = new Estudiante(Nombres, Edad, Calificacion);
            estudiantes.Add(estudiante);

            Console.WriteLine("Desea Salir");
            Salir= Console.ReadLine();

        } while (Salir.ToUpper() != "S");

        foreach (var item in estudiantes)
        {
            Console.WriteLine($"Nombres: {item.Nombre} Edad: {item.Edad} Calificación:{item.Calificacion} ");
        }
        */

        /*

        //NEW : INSTANCIAR
        Persona persona1 = new Persona();
        persona1.nombre = "Guillermo";
        persona1.edad = 31;
        persona1.ciudad = "Lima";

        Console.WriteLine(" Hola mi nombre es " + persona1.nombre);

        Calculadora calculadora1= new Calculadora();

        calculadora1.numero1 = 20;
        calculadora1.numero2= 10;

        Console.WriteLine("La suma es : " + calculadora1.Sumar());
        Console.WriteLine("La resta es : " + calculadora1.Restar());
        Console.WriteLine("La multiplicación es : " + calculadora1.Multiplicar());
        Console.WriteLine("La división es : " + calculadora1.Dividir());

        */
    }
}