using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePolymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Mère mère = new Mère(); //error si class mère abstract
            //Polymorphisme de class
            Mère femme = new Fille();
        }
         class Mère
        {
            //Implémentation 1
            double addition(int y,double x) // le compilateur raisonne les position des types et nom de methode
            {                               //et non le type de retour
                return x + y;
            }
            double addition(double x, int y)//(int x, double y) error 
            {
                return x + y;
            }

            //public abstract void affiche(); retourne une erreur si la class n'est pas abstact
            // et si on a class et methode abstract doit etre implementer au niveau des dessendants
            // methode abstraite ne doit jamais representer une implementation
            // donc pour garder l'implementation on utilise virtual et non abstract
            public virtual void affiche()
            {
                Console.WriteLine("Je suis une mere");
            }
        }
        class Fille : Mère //si mere internal et Fille public error
        {
            public override void affiche()
            {
                //si on met pas override le compilateur nous indique qu'une methode cache une autre shadowing on met new
                base.affiche();
                Console.WriteLine("Je suis une fille");
            }
            //Implémentation 1
            //Implémentation 2
        }
    }
}
