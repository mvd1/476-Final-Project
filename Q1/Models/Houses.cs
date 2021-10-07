using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q1.Models
{
    public class Houses
    {
        public List<Model> HouseList = new List<Model>();
        
        /*public Model GetHouse(int id)
        {
            Model m = null;

            foreach(Model model in HouseList)
            {
                if (model.houseID == id)
                {
                    m = model;
                
                }
            }
            return m;
        }*/


        public void CreateHouse(Model model)
        {
            HouseList.Add(model); 
        }

        /*public void UpdateHouse(Model model)
        {
            foreach(Model house in HouseList)
            {
                if (house.houseID == model.houseID) {
                    house.price = model.price;
                    house.address = model.address;
                    house.city = model.city;
                    house.zipCode = model.zipCode;
                    house.yearBuilt = model.yearBuilt;
                    house.propertyType = model.propertyType;
                    house.squareFeet = model.squareFeet;
                    house.numberOfBedrooms = model.numberOfBedrooms;
                    house.numberOfBathrooms = model.numberOfBathrooms;
                    house.numberOfCarGarage = model.numberOfCarGarage;
                    break;
                }
            }
        }

        public void DeleteHouse(Model model)
        {
            foreach(Model house in HouseList)
            {
                if (house.houseID == model.houseID)
                {
                    HouseList.Remove(house);
                    break; 
                }
            }
        }*/

    }
}
