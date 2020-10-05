using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesTypesGeneriques
{
    class Program
    {
        static void Main(string[] args)
        {
            //Covariance
            IEnumerable<Créature> créatures = new List<Homme>();
            // List<Homme> créatures = new List<Créature>(); 
            // error of compilation par ce que liste ne definit ni la covariance ni la contravariance
            //Contravariance
            Action<Créature> action = méthode;
        }

        private static void méthode(Créature obj)
        {
            throw new NotImplementedException();
        }

        public class ClasseDAppel
        {

            //Variance            Arrivée<----------- Départ //input output de meme type
            static public Homme variance(Homme homme)
            {
                return homme;
            }

            //Covariance          Arrivée<----------- Départ // output plus generalisé que les arguments input
            static public Créature covariance(Homme homme)
            {
                Créature créature = homme;
                return créature;
            }

            //Contravariance      Arrivée<----------- Départ // le type input est plus generalisé que le output
            static public Homme contravariance(Créature créature)
            {
                Homme homme = créature as Homme;
                return homme;
            }

        }

        public class Créature
        {
            //Implémentation
            public override string ToString()
            {
                return string.Format("Identifiant créature {0}"
                    , this.GetHashCode().ToString());
            }
        }

        public class Homme : Créature
        {
            public string Nom { get; set; }
            public string Prénom { get; set; }

            public override string ToString()
            {
                return string.Format("Nom={0}, Prénom={1}", Nom, Prénom);
            }
        }


    }
}
