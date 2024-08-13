using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string Manufacturer { get; set; }
        public string YearFounded { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }        
        public string BedSize { get; set; }
        public string Color { get ; set; }
        public int NumberOfDoors { get ; set; }
        public string EngineSize { get ; set;}
        public int NumberOfWheels { get; set; }
        public string HasManualTransmission { get ; set; }
       
        public void DisplayDetails()      
        {   
            string heading = "\t       My Truck";
            string divider = "***************************************";
            string message = $"Make: {Manufacturer}\nYear founded: {YearFounded}\n" +
                $"Model: {Model}\nYear: {Year}\nColor: {Color}\nBed size: {BedSize}\n" +
                $"Engine: {EngineSize}\nManual transmision: {HasManualTransmission}\n"+
                $"Number of doors: {NumberOfDoors}\nNumber of wheels: {NumberOfWheels}";
            Console.WriteLine(divider);
            Console.WriteLine(heading);
            Console.WriteLine(divider);
            Console.WriteLine(message);
            Console.WriteLine(divider);
            Console.WriteLine(Environment.NewLine);
        }

    }
}
