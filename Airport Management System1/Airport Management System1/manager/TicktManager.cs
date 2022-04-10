using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management_System1.manager
{
    class TicktManager
    {
        public static void AddTickt(string type, Boolean av, int price)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                db.Tickts.Add(new Tickt
                {

                    available = av,
                    type = type,
                    price = price,

                });
                db.SaveChanges();
            }
        }


        public static List<Tickt> GetAvailbleTickts()
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.Tickts.Where(x => x.available == true).ToList();
            }
        }

        public static void BookATickt(int ticktId, int flightId, int CustomerID)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                db.Resrvaations.Add(new Resrvaation
                {
                    CustomerId = CustomerID,
                    flightId = flightId,
                    R_Date = DateTime.Now,
                    ticketId = ticktId
                });

                var Ticket = db.Tickts.SingleOrDefault(t => t.Id == ticktId);
                Ticket.available = false;
                db.SaveChanges();
            }


        }


        public static double CheckDistance(int C_Id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                var Customer_Reservation = db.Resrvaations.Where(r => r.CustomerId == C_Id);
                List<int> IDS = Customer_Reservation.Select(f_id => (int)f_id.flightId).ToList();
                Double dist = 0;
                foreach (int id in IDS)
                {
                    dist += db.flights.Find(id).Distance;
                }
                return dist;


            }
        }


        public static double MakeDiscount(int t_id, int DiscountRatio)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                var t = db.Tickts.Find(t_id);
                t.price = t.price - (t.price)*((double)DiscountRatio / (double)100);
                db.SaveChanges();
                return t.price;
            }

        }

        public static double GetMonthlyIncom()
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                var R_Tickts_Ids = db.Resrvaations.Where(x => x.R_Date.Year == DateTime.Now.Year);
                List<int> IDS = R_Tickts_Ids.Select(x => (int)x.ticketId).ToList();
                double total = 0;
                // List<Customer> c = new List<Customer> ();
                foreach (int t_id in IDS)
                {
                    // c.add ( db.Customers.Find(t_id);
                    total += db.Tickts.Find(t_id).price;
                }
                return total / 12;
            }

        }

        public static List<Resrvaation> GetReservation()
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.Resrvaations.ToList();
            }
        }



        public static List<City> GetAvailableCity()
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.Cities.ToList();
            }
        }

        public static Tickt GetTicktInfo(int id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.Tickts.SingleOrDefault(i => i.Id == id);
            }
        }
        public static void editticktinfo(int id,string type, Boolean av, int price)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                Tickt t = db.Tickts.SingleOrDefault(i => i.Id == id);
                if (t != null)
                {
                    t.type = type;
                    t.available = av;
                    t.price = price;
                    

                }
                db.SaveChanges();
            }

        }

    }
}
