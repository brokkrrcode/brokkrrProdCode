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
    
    public partial class LifeInsuranceDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Nullable<bool> IsInsured { get; set; }
        public string InsuranceCompany { get; set; }
        public string Language { get; set; }
        public string FaceValue { get; set; }
        public string CoverageExpires { get; set; }
        public string Notes { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Path { get; set; }
        public string DeclarationDocBase64 { get; set; }
    }
}
