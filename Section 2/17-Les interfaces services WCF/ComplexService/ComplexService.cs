

namespace ComplexService
{



    public class ComplexService : IComplexService, IComplexSpecializedService
    {
        public string Addition(Complex c1, Complex c2)
        {
            Complex result = new Complex(c1.Réel + c2.Réel, c1.Imagianire + c2.Imagianire);
            return result.ToString();
        }

        public string Multiplication(Complex c1, Complex c2)
        {
            double Réel = c1.Réel * c2.Réel - c1.Imagianire * c2.Imagianire;
            double Imaginaire = c1.Réel * c2.Imagianire - c1.Imagianire * c2.Réel;
            Complex result = new Complex(Réel, Imaginaire);
            return result.ToString();
        }

        public string Soustraction(Complex c1, Complex c2)
        {
            Complex result = new Complex(c1.Réel - c2.Réel, c1.Imagianire - c2.Imagianire);
            return result.ToString();
        }
    }



}
