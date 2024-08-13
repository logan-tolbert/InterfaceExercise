using System;
using System.Net.Http;

namespace InterfaceExercise
{
    internal class Suv : IVehicle, ICompany
    {
        public string Manufacturer { get; set; }
        public string YearFounded { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string Color { get ; set; }
        public int NumberOfDoors { get ; set; }
        public string EngineSize { get ; set;}
        public string HasManualTransmission { get ; set; }
        public string HasThirdRow { get; set; }
        public string SuvType { get; set; }

        public void DisplayDetails()
        {
            string heading = "\t       My SUV";
            string divider = "***************************************";
            string message = $"Make: {Manufacturer}\nYear founded: {YearFounded}\n" +
                $"Model: {Model}\nYear: {Year}\nColor: {Color}\nType: {SuvType}\n" +
                $"Engine: {EngineSize}\nManual transmision: {HasManualTransmission}\n"+
                $"Number of doors: {NumberOfDoors}\nThird Row: {HasThirdRow}";
            Console.WriteLine(divider);
            Console.WriteLine(heading);
            Console.WriteLine(divider);
            Console.WriteLine(message);
            Console.WriteLine(divider);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
