

namespace Estructuras
{
    struct Estudiante
    {
        //Propiedades
        public string Nombre;
        public int Edad;
        public int Calificacion;

        //Comportamientos

        public Estudiante(string Nombre, int Edad, int Calificacion)
        {
            //nombre= pNombre;
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Calificacion = Calificacion;
        }

    }
}
