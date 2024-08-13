using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Channels;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            Car myCar = new Car()
            {
                 Manufacturer = "Toyota",
                 YearFounded = "1937",
                 Year = "2006",
                 Model = "Corolla",
                 Color = "Silver",
                 NumberOfDoors = 4,
                 EngineSize = "1.8L 4-cylinder",
                 BootOrTrunk = "Trunk",
                 CarType = "Compact",
                 HasManualTransmission ="No",
            };
                 

            
            Truck myTruck = new Truck()
            {
                 Manufacturer = "Dodge",
                 YearFounded = "1900",
                 Year = "2010",
                 Model = "RAM 3500 ST",
                 Color = "Red",
                 NumberOfDoors = 2,
                 EngineSize = "6.7L V6 Diesel",             
                 HasManualTransmission ="Yes",
                 NumberOfWheels = 6,
                 BedSize = "96.10in"
            };


            Suv mySuv = new Suv()
            {
                 Manufacturer = "Toyota",
                 YearFounded = "1937",
                 Year = "2020",
                 Model = "4Runner",
                 Color = "Orange",
                 NumberOfDoors = 5,
                 HasManualTransmission = "No",
                 EngineSize = "4.0L V6",
                 HasThirdRow = "Yes",
                 SuvType = "Mid-Size"
            };
            //Creatively display and organize their values
            myCar.DisplayDetails();
            mySuv.DisplayDetails();
            myTruck.DisplayDetails();
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
