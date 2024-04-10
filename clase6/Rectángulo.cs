namespace CodigoClase06
{
    struct Rectangulo
    {

        #region  Propiedades


        private double X1;
        private double Y1;
        private double X2;
        private double Y2;
        private double X3;
        private double Y3;
        private double X4;
        private double Y4;
        public string color;


        #endregion
        #region FuncionesPrivadas

        /// <summary>
        /// Calcula distancia entre puntos
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <param name="a2"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        private double CalcularDistancia(double a1, double b1, double a2, double b2)
        {
            double result;
            result = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            return result;

        }
        private double ObtenerAltura()
        {
            double result;
            result = CalcularDistancia(X1, Y1, X2, Y2);
            return result;
        }
        private double ObtenerBase()
        {
            double result;
            result = CalcularDistancia(X2, Y2, X3, Y3);
            return result;
        }

        #endregion

        #region FuncionesPublicas
        public Rectangulo(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;

        }

        public double CalcularArea()
        {
            double result;
            result = ObtenerBase() * ObtenerAltura();
            return result;
        }

        public double CalcularPerimetro()
        {
            double result;
            result = (ObtenerBase() + ObtenerAltura()) * 2;
            return result;
        }
        #endregion



    }
}