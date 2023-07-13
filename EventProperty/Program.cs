using System;

namespace stt
{
    class boiler
    {
        public boiler(float temp,float vol)
        {
            temperature = temp;
            volume = vol;


        }
        public float temperature { get; set; }
        public float volume { get; set; }

        public void onTemperatureChanged(float newTemperature)
        {
            if(newTemperature<temperature)
            {
                Console.WriteLine("turn on boiler");
            }
            else
            {
                Console.WriteLine("bolier close");
            }
        }
        public void onFuelChanged(float newVolume)
        {
            if(newVolume>volume)
            {
                Console.WriteLine("fuel stop");
            }else
            {
                Console.WriteLine("fuel up");
            };
        }

    }


    class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }
        // Cooler is activated when ambient
        //1
        //temperature is higher than this
        public float Temperature { get; set; }
        // Notifies that the temperature changed on
        //this instance
        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)
            {
                System.Console.WriteLine("Cooler:On");
            }
            else
            {
                System.Console.WriteLine("Cooler:Off");
            }
            
        }
    }
    class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature { get; set; }
        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                System.Console.WriteLine("Heater:On");
               
            }
            else
            {
                System.Console.WriteLine("Heater Off");
            }
            
                
        }
    }
    public class Thermostat
    {
        // Define the event publisher (initially without the sender)
        public Action<float>OnTemperatureChange { get; set; }
        public Action<float>OnVolumeChange { get; set; }
        //public  EventHandler<float> OnTemperatureChange//以函數指標為型別宣告的變數
        /*OnTemperatureChange stores a list of
        subscribers. Notice that only one delegate property is
        required to store all the subscribers. In other words, both
        the Cooler and the Heater instances will receive
        notifications of a change in the temperature from this
        single publisher*/
       
       

        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }//Get the field
            set
            {
                if (value != CurrentTemperature)
                {
                    //_CurrentTemperature = value;
                    // INCOMPLETE: Check for null needed
                    // Call subscribers
                    OnTemperatureChange?.Invoke(value);
                    // call to notify all subscribers
                    //Action<float> localOnChange = OnTemperatureChange;
                    //// assigns OnTemperatureChange to a second local delegate variable
                    ///*assigning a local variable and then using that local variable is sufficient for making the null check thread-safe.*/
                    //if (localOnChange != null)
                    //{
                    //    // Call subscribers
                    //    localOnChange(value);
                    //}
                }
            }
        }
        public float CurrentVolume
        {
            get { return _CurrentVolume; }
            set
            {
                if (value != CurrentVolume)
                {
                    _CurrentVolume = value;
                    OnVolumeChange?.Invoke(value);//這行會回傳null不知道為啥(從委派過來的)
                }
                    
                    
                
            }
        }
                

        private float _CurrentTemperature;
        private float _CurrentVolume;
    }



    class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);
            boiler boiler = new boiler(80,400);
            Action<float> delegate1 =heater.OnTemperatureChanged;
            Action<float> delegate2 = cooler.OnTemperatureChanged;
            Action<float> delegate3;


            string temperature;
            string Volume;
            //thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            //thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;
            //thermostat.OnTemperatureChange += boiler.onTemperatureChanged;
            delegate3 = delegate1;
            delegate3 += delegate2;
            delegate3(90);


            /*registered two subscribers
            (heater.OnTemperatureChanged and
            cooler.OnTemperatureChanged) to the
            OnTemperatureChange delegate by directly assigning
            them using the += operator*/
            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature =int.Parse(temperature);
            Console.WriteLine("Enter the Volume: ");
            thermostat.OnTemperatureChange += boiler.onFuelChanged;
            Volume = Console.ReadLine();
            thermostat.CurrentVolume = int.Parse(Volume);
            /*-----------------------------------------------*/
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            // Using C# 3.0. Change to anonymous method
            // if using C# 2.0
            thermostat.OnTemperatureChange +=
            (newTemperature) =>
            {
                throw new
                InvalidOperationException();
            };
            thermostat.OnTemperatureChange +=cooler.OnTemperatureChanged;
            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature =
            int.Parse(temperature);
            Console.ReadLine();

            
        }
    }
}



