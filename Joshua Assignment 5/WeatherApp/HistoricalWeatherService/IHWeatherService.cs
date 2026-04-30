using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HistoricalWeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHWeatherService" in both code and config file together.
    [ServiceContract]
    public interface IHWeatherService
    {

        [OperationContract]
        string getHistoricalWeatherData(DateTime startDate, DateTime endDate, decimal latitude, decimal longitude);
    }
}
