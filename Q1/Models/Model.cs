using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Q1.Models
{
    public class Model
    {
        public int houseID { get; set; }
        public double price { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public int zipCode { get; set; }
        public int yearBuilt { get; set; }
        public string propertyType { get; set; }
        public int squareFeet { get; set; }
        public int numberOfBedrooms { get; set; }
        public double numberOfBathrooms { get; set; }
        public double numberOfCarGarage { get; set; }
        public string realtorName { get; set; }
        public string realtorEmail { get; set; }
        public string realtorPhoneNumber { get; set; }

    }
}
