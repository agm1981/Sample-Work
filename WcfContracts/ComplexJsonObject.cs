using Newtonsoft.Json;

namespace WcfContracts
{
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