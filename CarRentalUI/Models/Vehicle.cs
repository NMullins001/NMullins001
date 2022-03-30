using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalUI.Models
{
    class Vehicle
    {
        public string VinNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Miles { get; set; }
        public string CarYear { get; set; }
        public string Condition { get; set; }
        public double PricePerDay { get; set; }
        public string IsRented { get; set; }

        public Vehicle(string vinNumber, string manufacturer, string model, string color, string type, int miles, string carYear, string condition, double pricePerDay,string isRented)
        {
            VinNumber = vinNumber;
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            Type = type;
            Miles = miles; 
            CarYear = carYear; 
            Condition = condition;
            PricePerDay = pricePerDay;
            IsRented = isRented;
        }
        public Vehicle()
        {
            
        }

        public override string ToString()
        {
            return String.Format(VinNumber + " " + Manufacturer + " " + Model + " " + CarYear + " " + PricePerDay +
                                 " " + Miles + " " + Color);
        }
    }
}
