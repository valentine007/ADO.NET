using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Cities
    {
        public string Country { get; set; }
        public List<string> City { get; set; } = new List<string>();

        public void addCity(string city)
        {
           
            City.Add(city);
        }

        public void removeCity(string city)
        {
            City.Remove(city);
        }
    }
}
