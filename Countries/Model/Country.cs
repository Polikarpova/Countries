using Newtonsoft.Json;

namespace Countries
{
    [JsonObject(MemberSerialization.OptOut)]
    public class Country
    {
        [JsonIgnore]
        public bool IsEmpty
        {
            get
            {
                if ( Name == "" && Code == "" && Capital== "" && Region == "" && Area == 0 && Population == 0)
                    return true;

                return false;
            }
        }

        public string Name;

        [JsonProperty("numericCode")]
        public string Code;
        public string Capital;
        public float Area;
        public int Population;
        public string Region;

        public Country()
        {
            Name = Code = Capital = Region = "";
            Area = Population = 0;
        }
    }
}
