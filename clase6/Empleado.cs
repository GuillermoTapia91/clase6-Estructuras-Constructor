

namespace Estructuras
{
    struct Empleado
    {
        //Propiedades
        public string Nombre;
        public int Salario;
        public string Departamento;

        //Comportamientos

        public Empleado(string Nombre, int Salario, string Departamento)
        {
            //nombre= pNombre;
            this.Nombre = Nombre;
            this.Salario = Salario;
            this.Departamento = Departamento;
        }

    }
}
