using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayExam2022_S00214097
{
    public class RentalProperty
    {
        //properties
        public int ID { get; set; }
        public Enum RentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //constructors

        //methods
        public void RentIncrease(int increase)
        {
            Price = Price + ((increase / 100) * Price);
        }
    }
}
