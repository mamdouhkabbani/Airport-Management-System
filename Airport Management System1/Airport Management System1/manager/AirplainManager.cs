using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management_System1.manager
{
    class Add_a_new_airplane
    {
        public static void add_airplane(string brand, string model, int serial_number, int capacity)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                db.AirPlains.Add(new AirPlain
                {
                    brand = brand,
                    number = model,
                    id = serial_number,
                    capacity = capacity

                    
                });
                db.SaveChanges();
                
            }
        }
    }
}