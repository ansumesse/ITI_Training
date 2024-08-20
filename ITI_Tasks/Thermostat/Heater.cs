using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat
{
    internal class Heater
    {
        private float temp;
        public float Tempreture { get => temp; set => temp = value; }

        public void TempreutreChangedHandler(float temperature)
        {
            if (temperature < temp)
                Console.WriteLine("Heater..... ON");
            else
                Console.WriteLine("Heater..... OFF");
        }

    }
}
