

namespace Estructuras
{
    struct Persona
    {
        //Propiedades
        public string nombre;
        public int edad;
        public string ciudad;

        //Comportamientos

        public Persona(string pNombre, int pEdad, string pCiudad)
        {
            nombre= pNombre;
            edad= pEdad;
            ciudad= pCiudad;
        }

    }
}
