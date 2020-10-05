

using System.ServiceModel;

namespace ComplexService
{


    [ServiceContract]
    public interface IComplexSpecializedService : IComplexService
    {
        [OperationContract]
        string Multiplication(Complex c1, Complex c2);
    }

}
