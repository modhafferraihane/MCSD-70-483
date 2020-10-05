using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Fille fille = new Fille();
        }
    }
    enum Couleur
    {
        Bleu,Vert,Noir,Marron,Gris
    };
    interface IADeuxYeux
    {
        Couleur CouleurYeux { get; set; }
    }
    interface IAVisage
    {
        object Nez { get; set; }
         object Bouche { get; set; }
        object Yeux { get; set; }
        Couleur CouleurYeux { get; set; }

    }
    class Humain : IADeuxYeux,IAVisage
    {
        //Implémentation implicite d'interface
        public Couleur CouleurYeux { get; set; }
        //Implémentation explicite d'interface
        Couleur IAVisage.CouleurYeux { get; set; }
        public object Nez { get; set; }
        public object Bouche { get; set ; }
        public object Yeux { get ; set; }
    }
    class Mere : Humain
    {
        
    }
    class Fille :Mere
    {

    }
    class Gazelle : IADeuxYeux
    {
        public Couleur CouleurYeux { get; set; }
    }
}
