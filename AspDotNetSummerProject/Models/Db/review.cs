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
    using System.ComponentModel.DataAnnotations;

    public partial class review
    {
        public int review_id { get; set; }
        [Required]
        public string comment { get; set; }
        public System.DateTime review_date { get; set; }
        public int customer_id { get; set; }
        public int trip_id { get; set; }
    }
}
