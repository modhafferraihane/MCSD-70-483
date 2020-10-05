using System.Runtime.Serialization;

namespace ComplexService
{


    [DataContract]
    public class Complex
    {
        [DataMember]
        public double Réel { get; set; }
        [DataMember]
        public double Imagianire { get; set; }

        public Complex(double réel, double imaginaire)
        {
            Réel = réel;
            Imagianire = imaginaire;
        }

        public override string ToString()
        {
            if (Imagianire < 0) return string.Format("{0} - {1}i", Réel, -Imagianire);
            else if (Imagianire == 0) return string.Format("{0}", Réel);
            else if (Réel == 0) return string.Format("{0}i", Imagianire);
            else return string.Format("{0} + {1}i", Réel, Imagianire);
        }
    }



}
