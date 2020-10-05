using System.Runtime.InteropServices;
using static Arithmetique.IOperations;

namespace Arithmetique
{

    [ComVisible(true), GuidAttribute("E8E9F986-97AA-4c22-A3A3-8C67991BD152")]
    [ProgId("Arithmetique.Operations")/*<-Pour établir qui sera le programme*/]
    [ClassInterface(ClassInterfaceType.None)]
    [ComDefaultInterface(typeof(IOperations)) /*<-Interface com exposée*/]
    public class Operations : IOperations.IOperations
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Soustraction(double x, double y)
        {
            return x + y;
        }

        public int PartieEntiere(double x)
        {
            return System.Convert.ToInt32(x);
        }
    }

}
