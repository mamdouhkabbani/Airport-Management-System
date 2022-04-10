using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management_System1.manager
{
    class CutomerManager
    {
        public static void Create_customer_account(string first_Name, string last_name, string pasport_number, string nationality, string phone_number, string email)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                db.Customers.Add(new Customer
                {

                    first_name = first_Name,
                    last_name = last_name,
                    passport_no = pasport_number,
                    nationality = nationality,
                    phone_no = phone_number,
                    email = email,

                });
                db.SaveChanges();


            }
        }

        public static Customer GetCustomerInfo(int id)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                return db.Customers.SingleOrDefault(i => i.Id == id);
            }
        }

        public static void EditCustomerInfo(int id, string fname, string lname, string passportNo, string nationality, string phoneNumber, string Email)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                Customer c = db.Customers.SingleOrDefault(i => i.Id == id);
                if (c != null)
                {
                    c.first_name = fname;
                    c.last_name = lname;
                    c.passport_no = passportNo;
                    c.email = Email;
                    c.nationality = nationality;
                    c.phone_no = phoneNumber;
                }
                db.SaveChanges();
            }
        }

    }
}
