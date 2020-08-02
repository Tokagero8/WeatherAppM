using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppM
{
    class WeatherForecastObservable : IObservable <WeatherForecast.major>
    {
        public WeatherForecastObservable()
        {
            observers = new List<IObserver<WeatherForecast.major>>();
        }

        private List<IObserver<WeatherForecast.major>> observers; //Lista obserwatorów obserwująca dostawcę.

        public IDisposable Subscribe(IObserver<WeatherForecast.major> observer) //Dodawanie obserwatora do listy obserwatorów.
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer); //Tworzenie objektu do usuwanięcia obserwatora.
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherForecast.major>> _observers;
            private IObserver<WeatherForecast.major> _observer;

            public Unsubscriber(List<IObserver<WeatherForecast.major>> observers, IObserver<WeatherForecast.major> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose() //Usunięcie obserwatora.
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void CheckWeather(string APIKEY, double lat, double lon) //Sprawdzenie prognozy pogody dla danego miasta (o danej szerokości i długości geograficznej).
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&appid={2}&units=metric&exclude=minutely,hourly,current", lat, lon, APIKEY); //Stworzenie zapytania.

                web.Encoding = Encoding.UTF8; //Dla polskich znaków (Kraków zamiast Krakow)
                try
                {
                    var json = web.DownloadString(url); //Pobierania JSON'a.

                    WeatherForecast.major weatherForecast = JsonConvert.DeserializeObject<WeatherForecast.major>(json); //Deserializacja do danego obiektu.

                    foreach (var observer in observers) //Wysłanie danych do każdego z obserwatorów.
                    {
                        observer.OnNext(weatherForecast);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while searching for the city: " + ex);
                }
            }
        }

        public void EndTransmission() //Zakończenie subskrypcji dla wszystkich obserwatorów.
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
