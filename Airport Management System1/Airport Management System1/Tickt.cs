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
    
    public partial class Tickt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tickt()
        {
            this.Resrvaations = new HashSet<Resrvaation>();
        }
    
        public int Id { get; set; }
        public string type { get; set; }
        public bool available { get; set; }
        public double price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resrvaation> Resrvaations { get; set; }
    }
}
