using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces_extension_Interoperbilité
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne = new Personne();
            //Définis personne;
            Process process = new Process(personne);
        }
        class Personne : IEntité
        {
            //Comprend des données et des méthodes
            public void méthode()
            {
                
            }
        }
        interface IEntité
        {
            void méthode();
        }
        class Process
        {
            //Traite des classes entité

            //DEPENDENCY INJECTION IOC INVERSION OF CONTROL
            IEntité _entité;
            public Process(IEntité entité)
            {
                _entité = entité;
            }

            void Enveloppe()
            {
                // Du code
                _entité.méthode();
                // Du code

            }
        }
    }
}
