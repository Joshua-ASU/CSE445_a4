using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherApp
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Weather_btn_Click(object sender, EventArgs e)
        {
            //TODO Connect to historical weather service

            //Temp display input information 
            
            try
            {
                DateTime startDate = Start_clndr.SelectedDate;
                DateTime endDate = End_clndr.SelectedDate;
                decimal latitude = Decimal.Parse(Lat_txt.Text);
                decimal longitude = Decimal.Parse(Long_txt.Text);

                string dateFormat = "yyyy-M-d";
                string sDate = startDate.ToString(dateFormat);
                string eDate = endDate.ToString(dateFormat);
                
                // TODO add service reference
                HWeatherRef.HWeatherServiceClient prxy = new HWeatherRef.HWeatherServiceClient();
                string resultData = prxy.getHistoricalWeatherData(startDate, endDate, latitude, longitude);
                
                Result_lbl.Text = resultData;
                //For now just ouputs input information
                //Result_lbl.Text = $"Start date: {sDate} End date: {eDate} latitude: {latitude.ToString()} longitude: {longitude.ToString()}";
            }
            catch (FormatException fe)
            {
                Result_lbl.Text = "Enter a valid longitude and latitude";
            }
            catch (Exception ex)
            {
                Result_lbl.Text = ex.Message;
            }


        }
    }
}