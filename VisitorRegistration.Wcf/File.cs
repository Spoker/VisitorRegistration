//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisitorRegistration.Wcf
{
    using System;
    using System.Collections.Generic;
    
    public partial class File
    {
        public string ID { get; set; }
        public string FileUrl { get; set; }
        public Nullable<int> VisitorID { get; set; }
    
        public virtual Visitor Visitor { get; set; }
    }
}