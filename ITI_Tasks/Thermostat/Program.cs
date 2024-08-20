namespace Thermostat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Heater heater = new Heater();
            heater.Tempreture = 30;
            Cooler cooler = new Cooler();
            cooler.Tempreture = 60;
            Thermomieter thermomieter = new Thermomieter();
            thermomieter.OnTempretureChanged += heater.TempreutreChangedHandler;
            thermomieter.OnTempretureChanged += cooler.TempreutreChangedHandler;
            
            thermomieter.Tempreture = 20;
            thermomieter.Tempreture = 80;
            

        }
    }
}
