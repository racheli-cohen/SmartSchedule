//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgeConstraint
    {
        public int id { get; set; }
        public int teacherId { get; set; }
        public int ageCode { get; set; }
    
        public virtual Age Age { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}