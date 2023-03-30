using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JasonSerialize
{
    [Serializable]
    public class customer
    {
       

        //有加attribution
        //會把JsonProperty指派的文字取代serialize後的變數名稱
        //[JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("totalsales")]
        public decimal TotalSales { get; set; }
        [JsonProperty("finalpurchaseDate")]
        public DateTime FinalPurchaseDate { get; set; }

        


    }
}
