using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Web;

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

        [OperationContract]
        [WebGet(UriTemplate = "GetInformation/{value}")]
        ComplexJsonObject GetInformation(string value);

        [OperationContract]
        [WebInvoke(UriTemplate = "PutInformation", 
            BodyStyle = WebMessageBodyStyle.Bare, 
            Method = "POST", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        WrapperObject PutInformation(ComplexJsonObject value);


        [OperationContract]
        [WebGet(UriTemplate = "GetDropDown")]
        List<WrapperObject> GetDropDown();

    }
}
