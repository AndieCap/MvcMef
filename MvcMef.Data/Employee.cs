//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcMef.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Wages { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public bool IsHourly { get; set; }
    
        public virtual Frequency Frequency { get; set; }
    }
}
