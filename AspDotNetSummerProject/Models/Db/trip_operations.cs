//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspDotNetSummerProject.Models.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class trip_operations
    {
        public int trip_id { get; set; }
        public string start_location { get; set; }
        public string end_location { get; set; }
        public string vechile_type { get; set; }
        public string price { get; set; }
        public Nullable<int> labour_number { get; set; }
        public System.DateTime date_time { get; set; }
        public string status { get; set; }
        public string product_description { get; set; }
        public int customer_id { get; set; }
        public Nullable<int> driver_id { get; set; }
        public string labour_id { get; set; }
    }
}
