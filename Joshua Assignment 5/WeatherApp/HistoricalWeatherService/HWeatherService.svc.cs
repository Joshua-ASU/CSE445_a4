using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HistoricalWeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HWeatherService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HWeatherService.svc or HWeatherService.svc.cs at the Solution Explorer and start debugging.
    public class HWeatherService : IHWeatherService
    {
        //Gets json containing historical weather information about daily mean temperature, relative humidity, and rain for a given coordinates and time range
        public string getHistoricalWeatherData(DateTime startDate, DateTime endDate, decimal latitude, decimal longitude)
        {
            string dateFormat = "yyyy-MM-dd";
            string sDate = startDate.ToString(dateFormat);
            string eDate = endDate.ToString(dateFormat);
            string result = "";
            try
            {
                Uri baseUri = new Uri("https://archive-api.open-meteo.com/v1");     //Base address for weather api
                UriTemplate template = new UriTemplate("archive?latitude={latitude}&longitude={longitude}&start_date={start_date}&end_date={end_date}&daily=rain_sum,relative_humidity_2m_mean,temperature_2m_mean");
                Uri completeUri = template.BindByPosition(baseUri, latitude.ToString(), longitude.ToString(), sDate, eDate); //Construct full uri
            

                WebClient channel = new WebClient();                                //Create channel
                string content = channel.DownloadString(completeUri);               //Convert to string

                result = content;

            
                WeatherData data = JsonConvert.DeserializeObject<WeatherData>(content);//Extract weather data from json response
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            

            return result;
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    public class WeatherData
{
    public decimal latitude;
    public decimal longitude;
    public decimal generationtime_ms;
    public int utc_offset_seconds;
    public string timezone;
    public string timezone_abbreviation;
    public double elevation;
    public DailyUnits daily_units;
    public Daily daily;
}
public class DailyUnits
{
    public string time;
    public string rain_sum;
    public string relative_humidity_2m_mean;
    public string temperature_2m_mean;
}
public class Daily
{
    public string[] time;
    public double[] rain_sum;
    public int[] relative_humidity_2m_mean;
    public double[] temperature_2m_mean;
}
}
