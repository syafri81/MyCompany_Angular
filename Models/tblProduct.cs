//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCompany.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProduct
    {
        public int IDProduct { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Size { get; set; }
        public bool IsActive { get; set; }
        public int IDCampaign { get; set; }
        public System.DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string Description { get; set; }
    }
}
