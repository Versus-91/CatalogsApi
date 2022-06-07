using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Catalogs
{
    public class WeatherForecast
    {
        /// <summary>
        /// تاریخ به میلادی
        /// <br /> 
        /// تاریخ به میلادی
        /// <br /> 
        /// تاریخ به میلادی
        /// <br /> 
        /// تاریخ به میلادی
        /// <br/>
        /// تاریخ به میلادی
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        [Required]
        [Range(0,1)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public Weathers Weather { get; set; } = Weathers.Cold;
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Weathers
    {
        Cold =1,
        Hot,
        Sandy
    }
}