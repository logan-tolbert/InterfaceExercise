using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InterfaceExercise
{
    
            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
    internal interface IVehicle
    {
        public string Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }  
        public int NumberOfDoors { get; set; }
        public string HasManualTransmission { get; set; }
        public string EngineSize { get; set; }

        public void DisplayDetails();
    }
}
