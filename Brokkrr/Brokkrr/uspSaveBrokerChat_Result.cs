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
    
    public partial class uspSaveBrokerChat_Result
    {
        public int Id { get; set; }
        public Nullable<int> BrokerMsgId { get; set; }
        public Nullable<int> CustMsgId { get; set; }
        public Nullable<int> BrokerId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string BrokerMessage { get; set; }
        public string CustomerMessage { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<System.DateTime> LocalDateTime { get; set; }
        public Nullable<bool> IsDeletedByCustomer { get; set; }
        public Nullable<bool> IsDeletedByBroker { get; set; }
        public System.DateTime MessageTime { get; set; }
    }
}
