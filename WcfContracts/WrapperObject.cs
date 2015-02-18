using System.Runtime.Serialization;

namespace WcfContracts
{
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
}