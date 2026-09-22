using Week1.Core;

namespace Week1
{

      
    public class Station
    {
        public string? Name { get; set; }

        public int Altitude_m { get; set; }
        public List<Reading> Readings { get; set; }

        public Station(string name, int altitude_m)
        {
            Name = name;
            Altitude_m = altitude_m;
        }

        public float? total_rainfall()
        {
            if (Readings is null || Readings.Count == 0)
            {
                return null;
            }
            else
            {
                float total = 0;
                foreach (Reading reading in Readings)
                {
                    total += reading.rainfall_mm;
                }
                return total;
            }
        }

        public float? average_temperature()
        {
            if (Readings is null || Readings.Count == 0)
            {
                return null;
            }
            else
            {
                float total = 0;
                foreach (Reading reading in Readings)
                {
                    total += reading.temperature;
                }
                return total / Readings.Count;
            }
        }

        public Reading? wettest_day()
        {
            Reading wettest = null;
            foreach (Reading reading in Readings)
            {
                if (wettest is null || reading.rainfall_mm > wettest.rainfall_mm)
                {
                    wettest = reading;
                }
            }
            return wettest;
        }
    }
}
