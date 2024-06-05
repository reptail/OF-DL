using Newtonsoft.Json.Converters;

namespace OF_DL.Entities
{
    public class ShortDateConverter : IsoDateTimeConverter
    {
        public ShortDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
