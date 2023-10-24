using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStorage
{
    class Device
    {
        static protected List<ForCooking> AllForCooking = new List<ForCooking>();
        static protected List<ForClothes> AllForClothes = new List<ForClothes>();

        private string Type;
        private string Company;
        private string Model;
        private string YearOfRelease;
        private string DeliveryDate;
        private string PlaceInTheStore;
        private string Сount;
        private string Provider;
       

        public Device(string type, string company, string model, string yearOfRelease)
        {
            Type = type;
            Company = company;
            Model = model;
            YearOfRelease = yearOfRelease;
           
           
        }
        public Device() { }

        public void ShowCatalog()
        {
            Console.WriteLine("Приборы для готовки");
            foreach (var device in AllForCooking)
            {
                Console.WriteLine(device.Type + ":");
                Console.WriteLine(device.Company);
                Console.WriteLine(device.Model);
                Console.WriteLine(device.YearOfRelease);
            }
            Console.WriteLine("Приборы для одежды");
            foreach (var device in AllForClothes)
            {
                Console.WriteLine($"{device.Type}:");
                Console.WriteLine();
                Console.WriteLine(device.Company);
                Console.WriteLine(device.Model);
                Console.WriteLine(device.YearOfRelease);
            }
           
        }
    }
}
