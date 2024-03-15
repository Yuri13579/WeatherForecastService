namespace WeatherForecast.Models
{
    public class WeatherVisualcrossing : IWeatherForecastModel
    {
        public int queryCost { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string resolvedAddress { get; set; }
        public string address { get; set; }
        public string timezone { get; set; }
        public double tzoffset { get; set; }
        public string description { get; set; }
        public List<WeatherVisualcrossingDay> days { get; set; }
        public List<Alert> alerts { get; set; }
        public Stations stations { get; set; }
        public CurrentConditions currentConditions { get; set; }
    }
    public class Alert
    {
        public string @event { get; set; }
        public string headline { get; set; }
        public DateTime ends { get; set; }
        public int endsEpoch { get; set; }
        public DateTime onset { get; set; }
        public int onsetEpoch { get; set; }
        public string id { get; set; }
        public string language { get; set; }
        public string link { get; set; }
        public string description { get; set; }
    }

    public class AU686
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }

    public class C1292
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }

    public class CurrentConditions
    {
        public string datetime { get; set; }
        public int datetimeEpoch { get; set; }
        public double temp { get; set; }
        public double feelslike { get; set; }
        public double humidity { get; set; }
        public double dew { get; set; }
        public double precip { get; set; }
        public double precipprob { get; set; }
        public double snow { get; set; }
        public double snowdepth { get; set; }
        public object preciptype { get; set; }
        public double windgust { get; set; }
        public double windspeed { get; set; }
        public double winddir { get; set; }
        public double pressure { get; set; }
        public double visibility { get; set; }
        public double cloudcover { get; set; }
        public double solarradiation { get; set; }
        public double solarenergy { get; set; }
        public double uvindex { get; set; }
        public string conditions { get; set; }
        public string icon { get; set; }
        public List<string> stations { get; set; }
        public string source { get; set; }
        public string sunrise { get; set; }
        public int sunriseEpoch { get; set; }
        public string sunset { get; set; }
        public int sunsetEpoch { get; set; }
        public double moonphase { get; set; }
    }

    public class D3623
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }

    public class D7697
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }

    public class WeatherVisualcrossingDay
    {
        public string datetime { get; set; }
        public int datetimeEpoch { get; set; }
        public double tempmax { get; set; }
        public double tempmin { get; set; }
        public double temp { get; set; }
        public double feelslikemax { get; set; }
        public double feelslikemin { get; set; }
        public double feelslike { get; set; }
        public double dew { get; set; }
        public double humidity { get; set; }
        public double precip { get; set; }
        public double precipprob { get; set; }
        public double precipcover { get; set; }
        public List<string> preciptype { get; set; }
        public double snow { get; set; }
        public double snowdepth { get; set; }
        public double windgust { get; set; }
        public double windspeed { get; set; }
        public double winddir { get; set; }
        public double pressure { get; set; }
        public double cloudcover { get; set; }
        public double visibility { get; set; }
        public double solarradiation { get; set; }
        public double solarenergy { get; set; }
        public double uvindex { get; set; }
        public double severerisk { get; set; }
        public string sunrise { get; set; }
        public int sunriseEpoch { get; set; }
        public string sunset { get; set; }
        public int sunsetEpoch { get; set; }
        public double moonphase { get; set; }
        public string conditions { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public List<string> stations { get; set; }
        public string source { get; set; }
        public List<WeatherVisualcrossingHour> hours { get; set; }
    }

    public class WeatherVisualcrossingHour
    {
        public string datetime { get; set; }
        public int datetimeEpoch { get; set; }
        public double temp { get; set; }
        public double feelslike { get; set; }
        public double humidity { get; set; }
        public double dew { get; set; }
        public double precip { get; set; }
        public double precipprob { get; set; }
        public double snow { get; set; }
        public double snowdepth { get; set; }
        public List<string> preciptype { get; set; }
        public double windgust { get; set; }
        public double windspeed { get; set; }
        public double winddir { get; set; }
        public double pressure { get; set; }
        public double visibility { get; set; }
        public double cloudcover { get; set; }
        public double solarradiation { get; set; }
        public double solarenergy { get; set; }
        public double uvindex { get; set; }
        public double severerisk { get; set; }
        public string conditions { get; set; }
        public string icon { get; set; }
        public List<string> stations { get; set; }
        public string source { get; set; }
    }

    public class LFPB
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }

    public class LFPO
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }

    public class LFPV
    {
        public double distance { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int useCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double contribution { get; set; }
    }
    public class Stations
    {
        public LFPV LFPV { get; set; }
        public D7697 D7697 { get; set; }
        public C1292 C1292 { get; set; }
        public LFPO LFPO { get; set; }
        public AU686 AU686 { get; set; }
        public D3623 D3623 { get; set; }
        public LFPB LFPB { get; set; }
    }
}
