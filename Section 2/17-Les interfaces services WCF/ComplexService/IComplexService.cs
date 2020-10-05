

using System.ServiceModel;

namespace ComplexService
{

    [ServiceContract]
    public interface IComplexService
    {
        [OperationContract]
        string Addition(Complex c1, Complex c2);
        [OperationContract]
        string Soustraction(Complex c1, Complex c2);
    }


}
