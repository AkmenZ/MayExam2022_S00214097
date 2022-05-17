using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MayExam2022_S00214097
{
    public enum RentalType { Flat, House, Share}
    public class RentalProperty
    {
        //properties
        public int ID { get; set; }
        public RentalType TypeOfRental { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //constructors

        //methods
        public void RentIncrease(int increase)
        {
            Price = Price + (increase / 100 * Price);
        }
        public override string ToString()
        {
            return $"{Location} {Price:C}";
        }

    }

    public class RentalPropertyData : DbContext
    {
        public RentalPropertyData() : base("MyNewRentalPropertyData2022") { }

        public DbSet<RentalProperty> RentalProperties { get; set; }
    }
}
