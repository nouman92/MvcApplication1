//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class addre
    {
        public addre()
        {
            this.users = new HashSet<user>();
        }
    
        public int Id { get; set; }
        public string street { get; set; }
        public Nullable<int> city { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> country { get; set; }
    
        public virtual city city1 { get; set; }
        public virtual state state1 { get; set; }
        public virtual Country Country1 { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}
