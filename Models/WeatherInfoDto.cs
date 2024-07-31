namespace WeatherApp.Models
{
    public class WeatherInfoDto
    {
        public string? Title { get; set; }
        public string? TempValue { get; set; }
        public string? TempDescription { get; set; }
        public string? TempMax { get; set; }
        public string? TempMin { get; set; }
        public string? Humidity { get; set; }
        public string? Wind { get; set; }
        public string? ImgUrl { get; set; }
    }
}
