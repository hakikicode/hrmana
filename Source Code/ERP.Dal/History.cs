//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public System.Guid HistoryID { get; set; }
        public string Description { get; set; }
        public string TableId { get; set; }
        public int TableTypeId { get; set; }
        public int OperationTypeId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string XmlContent { get; set; }
        public string IPAddress { get; set; }
    }
}
