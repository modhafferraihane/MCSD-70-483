using System.Runtime.InteropServices;

namespace Arithmetique
{
    public class IOperations
    {

        /* Il est préférable d avoir une interface, car
      vous êtes complètement sûr de ce que vous exposez ou non */
        [ComVisible(true), /* <- son est évident parce que vous voulez utiliser votre classe dans le COM*/
         Guid("137AD71F-4657-4362-B9E4-C6D734F1F530")]
        /*https://msdn.microsoft.com/fr-fr/library/tz0x1301(v=vs.110).aspx*/
        [InterfaceType(ComInterfaceType.InterfaceIsDual)]
        public interface IOperations
        {
            double Addition(double x, double y);
            double Soustraction(double x, double y);
        }




        //[assembly:AssemblyKeyFile("Arithmetique.snk")]

        //regasm  /u "(TargetName).dll" /tlb /codebase

    }
}
