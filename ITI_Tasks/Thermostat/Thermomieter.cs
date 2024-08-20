using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat
{
    internal class Thermomieter
    {
        private float Cureenttemp; 
        public float Tempreture
        {
            get => Cureenttemp; 
            set  
            { 
                if(Cureenttemp != value)
                {
                    Cureenttemp = value;
                    if (OnTempretureChanged != null)
                        OnTempretureChanged(Cureenttemp);
                    
                }
               

            } 
        }
        public event Action<float> OnTempretureChanged;
    }
}
