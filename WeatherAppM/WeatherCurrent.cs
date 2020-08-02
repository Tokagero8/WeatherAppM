using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppM
{
    public class WeatherCurrent //Klasa do przechowywania informacji o obecnej pogodzie
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class weather
        {
            public string icon { get; set; } //Ikonka pogody
        }

        public class main
        {
            private int tempInt;
            public double temp { get => tempInt; set => tempInt = Convert.ToInt32(value); } //Przełożenie temperatury z double na int aby ładniej wyglądało.
        }

        public class major
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public string name { get; set; } //Nazwa miasta
        }
    }
}
