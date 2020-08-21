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
    class WeatherForecastObserver : IObserver<WeatherForecast.major>
    {
        private IDisposable unsubscriber;
        public Form1 form;

        public WeatherForecastObserver(Form1 form)
        {
            this.form = form;
        }

        public virtual void Subscribe(IObservable<WeatherForecast.major> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
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

        public void OnNext(WeatherForecast.major value)
        {
            string[] Days = new string[5];
            string[] Descriptions = new string[5];
            string[] Temperatures = new string[5];
            Image[] Icons = new Image[5];
            Parallel.For(1, 6, i =>
            {
                Days[i - 1] = getDate(value.daily[i].dt).DayOfWeek.ToString();
                Descriptions[i - 1] = value.daily[i].weather[0].description;
                Temperatures[i - 1] = value.daily[i].temp.day + "\u00B0" + "C";
                Icons[i - 1] = setIcon(value.daily[i].weather[0].icon);
            });
            form.SetForecast(Days, Descriptions, Temperatures, Icons);
        }
        Image setIcon(string iconID)
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

        DateTime getDate(double seconds)
        {
            DateTime date = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).ToLocalTime().AddSeconds(seconds).ToLocalTime();
            return date;
        }
    }
}
