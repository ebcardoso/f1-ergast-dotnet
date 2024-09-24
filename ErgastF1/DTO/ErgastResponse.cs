using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class ErgastResponse<T>
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public T Data;
    }
}