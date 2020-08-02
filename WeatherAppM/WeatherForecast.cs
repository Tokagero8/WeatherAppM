using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppM
{
    public class WeatherForecast ////Klasa do przechowywania informacji o prognozie pogody
    {
        public class temp
        {
            private int dayInt;
            public double day { get => dayInt; set => dayInt = Convert.ToInt32(value); } //Temperatura w czasie dnia (11:00) przełożona z double na int, aby ładniej wyglądało.
        }

        public class weather
        {
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class daily
        {
            public double dt { get; set; }
            public temp temp { get; set; }
            public List<weather> weather { get; set; }
        }

        public class major
        {
            public List<daily> daily { get; set; }
        }
    }
}
