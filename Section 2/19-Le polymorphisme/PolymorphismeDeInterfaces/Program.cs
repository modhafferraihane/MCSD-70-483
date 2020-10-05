using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeDeInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphisme de interfaces
           ISurface icarre = new Carre { Arete = 3 };
            double surfaceCarre = icarre.getSurface();

            ISurface icube = new Cube { Arete = 3 };
            double surfaceCube = icube.getSurface();
        }

        interface ISurface
        {
            double getSurface();
        }
        class Carre : ISurface
        {
            public double Arete { get; set; }
            public double getSurface()
            {
                return System.Math.Sqrt(Arete);
            }
        }
        class Cube : Carre
        {
            
            new public double getSurface() //double ISurface.getSurface() //error //on doit implementer ISurface
            {
                return System.Math.Sqrt(Arete)*6;

            }
        }
    }
}
