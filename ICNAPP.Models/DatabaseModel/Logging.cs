//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICNAPP.Models.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Logging
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public string MethodName { get; set; }
        public string ExceptionMessage { get; set; }
        public string InnerExceptionMessage { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
