//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrokerMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubIndustryMaster
    {
        public int Id { get; set; }
        public Nullable<int> IndustryId { get; set; }
        public string SICCode { get; set; }
        public string SubIndustryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CompanyId { get; set; }
    }
}
