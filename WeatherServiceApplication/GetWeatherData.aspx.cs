using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherServiceApplication
{
    public partial class GetWeatherData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void btnGetWeather_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSoapClient client = new WeatherService.WeatherSoapClient("WeatherSoap");
            WeatherService.WeatherReturn returnResult = client.GetCityWeatherByZIP(txtZip.Text);  

            //retrieve returned data into form fields if success

            if (returnResult.Success)
            {
                int weatherID = returnResult.WeatherID;
                lblCity.Text = returnResult.City;
                lblState.Text = returnResult.State;
                lblTemperature.Text = returnResult.Temperature;
                lblWind.Text = returnResult.Wind;
                lblPressure.Text = returnResult.Pressure;
                lblHumidity.Text = returnResult.RelativeHumidity;
                lblWeatherStationCity.Text = returnResult.WeatherStationCity;
                lblDescription.Text = returnResult.Description;

                switch (weatherID)
                {
                    case 1:
                        Image1.ImageUrl= "http://ws.cdyne.com/WeatherWS/Images/thunderstorms.gif";
                        break;
                    case 2:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
                        break;
                    case 3:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudy.gif";
                        break;
                    case 4:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/sunny.gif";
                        break;
                    case 5:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
                        break;
                    case 6:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/showers.gif";
                        break;
                    case 7:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/haze.gif";
                        break;
                    case 9:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudy.gif";
                        break;
                    case 10:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
                        break;
                    case 11:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/sunny.gif";
                        break;
                    case 12:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
                        break;
                    case 14:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudy.gif";
                        break;
                    case 15:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/na.gif";
                        break;
                    case 17:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/drizzle.gif";
                        break;
                    case 18:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/fog.gif";
                        break;
                    case 20:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
                        break;
                    case 21:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
                        break;
                    case 26:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
                        break;
                    case 27:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/snow.gif";
                        break;
                    case 28:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
                        break;
                    case 29:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
                        break;
                    case 32:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
                        break;
                    case 33:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
                        break;
                    case 34:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/na.gif";
                        break;
                    case 35:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
                        break;
                    case 36:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/na.gif";
                        break;
                    case 37:
                        Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
                        break;
                    default :
                        break;

                }

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = returnResult.ResponseText;
                lblCity.Text = string.Empty;
                lblState.Text = string.Empty;
                lblTemperature.Text = string.Empty;
                lblWind.Text = string.Empty;
                lblPressure.Text = string.Empty;
                lblHumidity.Text = string.Empty;
                lblWeatherStationCity.Text = string.Empty;
                lblDescription.Text = string.Empty;
                Image1.ImageUrl = string.Empty;
            }


          
        }
    }
}