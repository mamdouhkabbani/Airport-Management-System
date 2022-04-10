using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management_System1.manager
{
    class Create_a_new_flight
    {
        public static void AddFlight(int source, int destination, DateTime departure_date, DateTime arrival_date
            , float duration, int airplainId)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                db.flights.Add(new flight
                {
                    AirPlainId = airplainId,
                    FromCity = source,
                    ToCity = destination,
                    DepartureDate = departure_date,
                    ArriveDate = arrival_date,
                    time = duration


                });
                db.SaveChanges();

            }
        }

        
        public static List<Tickt> ViewTicktOFFlight(int f_id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
               var r_tickts=  db.Resrvaations.Where(r => r.flightId == f_id).ToList();
                List<Tickt> result = new List<Tickt>();
                foreach(var r in r_tickts)
                {
                    var tt= db.Tickts.SingleOrDefault(t => t.Id == r.ticketId);
                    if(tt != null)
                    {
                        result.Add(tt);
                    }
                }
                return result;
                
            }
        }

        public static flight Viewtlight(int f_id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.flights.SingleOrDefault(f => f.id == f_id);
            }
        }
        public static flight getticktinfo(int id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.flights.SingleOrDefault(i => i.id == id);
            }
        }



        public static flight getflightinfo(int id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.flights.SingleOrDefault(i => i.id == id);
            }
        }

        public static void editflight(int id, int source, int destination, DateTime departure_date
            , DateTime arrival_date, float duration, int airplainId)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                flight f = db.flights.SingleOrDefault(i => i.id == id);
                if (f != null)
                {
                    f.FromCity = source;
                    f.ToCity = destination;
                    f.DepartureDate = departure_date;
                    f.ArriveDate = arrival_date;
                    f.time = duration;
                    f.AirPlainId = airplainId;
                    



                }
                db.SaveChanges();
            }

        }

        public static List<flight> GetListOfFlightFromTo(int from, int to)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.flights.Where(x => x.FromCity == from && x.ToCity == to).ToList();
            }
        }
    }
}
