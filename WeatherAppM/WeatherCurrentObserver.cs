using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppM
{
    class WeatherCurrentObserver : IObserver<WeatherCurrent.major>
    {
        private IDisposable unsubscriber;
        public Form1 form;

        public WeatherCurrentObserver(Form1 form)
        {
            this.form = form;
        }

        public virtual void Subscribe(IObservable<WeatherCurrent.major> provider) //Subskrybowanie dostawcy
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }
        public virtual void Unsubscribe() //Odsubskrybowanie dostawcy
        {
            unsubscriber.Dispose();
        }
        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            MessageBox.Show("City was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public void OnNext(WeatherCurrent.major value)
        {
            form.SetWeather(value.name, value.main.temp, setIcon(value.weather[0].icon));
            form.LatLonSet(value.coord.lat, value.coord.lat);
        }

        Image setIcon(string iconID) //Uzyskiwanie ikony pogody z uzyskanych danych
        {
            string url = string.Format("http://openweathermap.org/img/wn/{0}@2x.png", iconID);
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image weatherImg = Bitmap.FromStream(weatherIcon);
                return weatherImg;
            }
        }
    }
}
