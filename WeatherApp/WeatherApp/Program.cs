namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var userURL = ($"");

            Console.WriteLine("Please input your API-key: ");
            var apiKey = Console.ReadLine();

            Console.WriteLine("Please input you cityname: ");
            var cityName = Console.ReadLine().ToLower();

            var getWeatherResult = client.GetStringAsync(userURL).Result;

            



        }
    }
}