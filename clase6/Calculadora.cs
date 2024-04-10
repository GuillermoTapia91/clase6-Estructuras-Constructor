

namespace Estructuras
{
    struct Calculadora
    {
        //Propiedades

        public int numero1;
        public int numero2;

        //Comportamientos
        public int Restar() { return numero1 - numero2; }
        public int Sumar() { return numero1 + numero2; }
        public int Multiplicar() { return numero1 * numero2; }
        public int Dividir() { return numero1 / numero2; }
    }
}
