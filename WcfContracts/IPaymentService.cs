using System.Collections.Generic;
using System.ServiceModel;
namespace WcfContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPaymentService" in both code and config file together.
    [ServiceContract]
    public interface IPaymentService
    {
        [OperationContract]
        int ApplyPayment();


        [OperationContract]
        int ApplyVoid();

        [OperationContract]
        int ApplyRefund();


    }
    
}
