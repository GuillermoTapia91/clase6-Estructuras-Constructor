

namespace Estructuras
{
    struct Cursos
    {
        //PROPIEDADES
        public string Nombre;
        public int DuracionSemanas;
        public int Precio;


        //Constructor
        public Cursos(string Nombre, int DuracionSemanas, int Precio)
        {
            this.Nombre = Nombre;
            this.DuracionSemanas = DuracionSemanas;
            this.Precio = Precio;
        }

        public void informacionCurso()
        {
            Console.WriteLine($"El curso de {Nombre} con una duración de {DuracionSemanas} semanas tiene" +
            $" un precio de {Precio} soles");

        }
    }
}
