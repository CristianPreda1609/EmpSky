//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpSky
{
    using System;
    using System.Collections.Generic;
    
    public partial class Taskuri
    {
        public int Id { get; set; }
        public Nullable<int> AngajatId { get; set; }
        public string Descriere { get; set; }
        public Nullable<System.DateTime> DataLimita { get; set; }
        public Nullable<int> Scor { get; set; }
    
        public virtual Angajati Angajati { get; set; }
    }
}
