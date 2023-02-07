namespace WebApplication1
{
    public class WeatherForecast
    {
        //TEST
        public DateOnly Date { get; set; }

        //Temperatura en grados Celsius
        public int TemperatureC { get; set; }

        //Temperatura en grados Fahrenheit
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //Resumen
        public string? Summary { get; set; }
    }
}