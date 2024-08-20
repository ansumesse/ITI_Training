using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat
{
    internal class Cooler
    {
        private float temp;
        public float Tempreture { get => temp; set => temp = value; }
        
        public void TempreutreChangedHandler(float temperature)
        {
            if(temperature > temp)
                Console.WriteLine("Cooler..... ON");
            else
                Console.WriteLine("Cooler..... OFF");
        }
    }
}
