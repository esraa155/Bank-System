//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Log_in
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE_PHONE
    {
        public long PHONE_EMPLOYEE { get; set; }
        public long EMPLOYEEID { get; set; }
        public long EMPLOYEE_ID { get; set; }
    
        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}
