using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert a list of object to jason
            var customers = new List<customer>
            {
                new customer()
                {
                    Name = "howard",
                    Age = 18,
                    Email = "howard40729@gg.com",
                    TotalSales = 185,
                    FinalPurchaseDate = new DateTime(2022, 3, 29)

                },
                new customer
                {
                    Name = "Peter",
                    Age = 14,
                    Email = "p40729@gg.com",
                    TotalSales = 18,
                    FinalPurchaseDate = new DateTime(2022, 4, 1)
                }
            };//convert a list of object to jason
            //convert single  object to jason 
            var customer1 = new customer
            {
                Name = "kevin",
                Age = 14,
                Email = "k40729@gg.com",
                TotalSales = 19,
                FinalPurchaseDate = new DateTime(2022, 9, 1)
            };

            //var jsonstring = "[{\"Name\":\"howard\",\"Email\":\"howard40729@gg.com\",\"Age\":18,\"TotalSales\":185.0,\"FinalPurchaseDate\":\"2022-03-29T00:00:00\"},{\"Name\":\"Peter\",\"Email\":\"p40729@gg.com\",\"Age\":14,\"TotalSales\":18.0,\"FinalPurchaseDate\":\"2022-04-01T00:00:00\"}]";
            //var jsonList2 = JsonConvert.DeserializeObject(jsonstring);
            var jsonstring = "[{\"Name\":\"howard\",\"email\":\"howard40729@gg.com\",\"age\":18,\"totalsales\":185.0,\"finalpurchaseDate\":\"2022-03-29T00:00:00\"},{\"Name\":\"Peter\",\"email\":\"p40729@gg.com\",\"age\":14,\"totalsales\":18.0,\"finalpurchaseDate\":\"2022-04-01T00:00:00\"}]";
            //var jsonList = JsonConvert.DeserializeObject <List<Customer>>(jsonstring);
            var jsonList = JsonConvert.DeserializeObject(jsonstring);

                //var customerJson = JsonConvert.SerializeObject(customers);
           // Console.WriteLine(customerJson); //convert single  object to jason 
            Console.WriteLine(jsonList);
            Console.ReadKey();
            

        }
        
    }
}
