//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airport_Management_System1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resrvaation
    {
        public int id { get; set; }
        public System.DateTime R_Date { get; set; }
        public int flightId { get; set; }
        public int CustomerId { get; set; }
        public int ticketId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual flight flight { get; set; }
        public virtual Tickt Tickt { get; set; }
    }
}
