using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppM
{
    class WeatherCurrentObservable : IObservable<WeatherCurrent.major>
    {
        public WeatherCurrentObservable()
        {
            observers = new List<IObserver<WeatherCurrent.major>>(); 
        }

        private List<IObserver<WeatherCurrent.major>> observers; //Lista obserwatorów obserwująca dostawcę.

        public IDisposable Subscribe(IObserver<WeatherCurrent.major> observer) //Dodawanie obserwatora do listy obserwatorów.
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer); //Tworzenie objektu do usuwanięcia obserwatora.
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherCurrent.major>> _observers;
            private IObserver<WeatherCurrent.major> _observer;

            public Unsubscriber(List<IObserver<WeatherCurrent.major>> observers, IObserver<WeatherCurrent.major> observer)
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

        public void CheckWeather(string city, string APIKEY) //Sprawdzenie obecnej pogody dla danego miasta.
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=pl", city, APIKEY); //Stworzenie zapytania.

                web.Encoding = Encoding.UTF8; //Dla polskich znaków (Kraków zamiast Krakow)
                try
                {
                    var json = web.DownloadString(url); //Pobierania JSON'a.

                    WeatherCurrent.major weatherCurrent = JsonConvert.DeserializeObject<WeatherCurrent.major>(json); //Deserializacja do danego obiektu.

                    foreach (var observer in observers) //Wysłanie danych do każdego z obserwatorów.
                    {
                        observer.OnNext(weatherCurrent);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while searching for the city: " + ex);
                    foreach (var observer in observers) //Wysłanie błędu do każdego z obserwatorów.
                    {
                        observer.OnError(ex);
                    }
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
