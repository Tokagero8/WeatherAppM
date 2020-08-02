using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppM
{
    public partial class Form1 : Form
    {
        const string APIKEY = "6fc7e6b09e360b4014144b458f008d1e"; //Kod używany do uzyskania pogody.
        string basicCity = "Kraków"; //Przykładowe miasto wyświetlające się na starcie.
        double Lat = 50.08; double Lon = 19.92; //Szerokość i długość geograficzna przykładowego miasta. API w darmowej wersji nie pozwala odnajdywać prognozy pogody po nazwie tak jak ma to miejsce w przypadku obecnej pogody, dlatego też wykorzystuję położenie uzyskane z zapytania obecnej pogody, aby wykorzystać je do zapytania prognozy pogody.
        WeatherCurrentObservable weatherObservable; //Dostawca obecnej pogody.
        WeatherCurrentObserver weatherObserver; //Obserwator obecnej pogody.
        WeatherForecastObservable weatherObservable2; //Dostawca prognozy pogody.
        WeatherForecastObserver weatherObserver2; //Obserwator prognozy pogody.
        public Form1()
        {
            InitializeComponent();
            //Inicjowanie początkowej obecnej pogody i prognozy pogody.
            weatherObservable = new WeatherCurrentObservable();
            weatherObserver = new WeatherCurrentObserver(this); //Przekazywany jest 'this' aby obserwator mógł stosować metody zawartę w tej klasie.
            weatherObserver.Subscribe(weatherObservable);
            weatherObservable.CheckWeather(basicCity, APIKEY);

            weatherObservable2 = new WeatherForecastObservable();
            weatherObserver2 = new WeatherForecastObserver(this);
            weatherObserver2.Subscribe(weatherObservable2);
            weatherObservable2.CheckWeather(APIKEY, Lat, Lon);
        }

        public void LatLonSet(double Lat, double Lon) //Ustawianie szerokości i długości geograficznej.
        {
            this.Lat = Lat;
            this.Lon = Lon;
        }

        public void SetWeather(string name, double temp, Image icon) //Ustawianie GUI dla obecnej pogody.
        {
            labelCityName.Text = name;
            labelTemperature.Text = temp + "\u00B0" + "C";
            pictureBoxWeatherIcon.Image = icon;
        }

        public void SetForecast(string[] Days, string[] Descriptions, string[] Temperatures, Image[] Icons) //Ustawianie GUI dla prognozy pogody.
        {
            //Day1
            labelDays1.Text = Days[0];
            labelDescription1.Text = Descriptions[0];
            labelTemperature1.Text = Temperatures[0];
            pictureBoxWeatherIcon1.Image = Icons[0];

            //Day2
            labelDays2.Text = Days[1];
            labelDescription2.Text = Descriptions[1];
            labelTemperature2.Text = Temperatures[1];
            pictureBoxWeatherIcon2.Image = Icons[1];

            //Day3
            labelDays3.Text = Days[2];
            labelDescription3.Text = Descriptions[2];
            labelTemperature3.Text = Temperatures[2];
            pictureBoxWeatherIcon3.Image = Icons[2];

            //Day4
            labelDays4.Text = Days[3];
            labelDescription4.Text = Descriptions[3];
            labelTemperature4.Text = Temperatures[3];
            pictureBoxWeatherIcon4.Image = Icons[3];

            //Day5
            labelDays5.Text = Days[4];
            labelDescription5.Text = Descriptions[4];
            labelTemperature5.Text = Temperatures[4];
            pictureBoxWeatherIcon5.Image = Icons[4];
        }

        //Program wyszukuje podanego miasta po przez kliknięcie przycisku Search, lub wciśnięcia klawisza Enter.
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                weatherObservable.CheckWeather(textBoxSearch.Text, APIKEY);
                weatherObservable2.CheckWeather( APIKEY, Lat, Lon);
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                weatherObservable.CheckWeather(textBoxSearch.Text, APIKEY);
                weatherObservable2.CheckWeather(APIKEY, Lat, Lon);
            }
        }
    }
}
