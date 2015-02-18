using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Newtonsoft.Json;

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

    }

    [DataContract]
    public class WrapperObject
    {
        [DataMember]
        public string Value
        {

            get;
            set;
        }
        public WrapperObject(string value)
        {
            Value = value;
        }

    }
    public class ComplexJsonObject
    {
        [JsonProperty]
        public string Name
        {
            get;
            set;
        }
        [JsonProperty]
        public string Value
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Value);
        }
    }
    
}
