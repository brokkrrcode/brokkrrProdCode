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
    
    public partial class BrokerMessage
    {
        public int Id { get; set; }
        public int BrokerId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> ContactDate { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<int> CustomerMsgId { get; set; }
        public Nullable<System.DateTime> LocalDateTime { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string DeclarationDocPath { get; set; }
        public string DeclarationDocBase64 { get; set; }
    }
}