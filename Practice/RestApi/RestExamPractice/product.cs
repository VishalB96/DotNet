//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestExamPractice
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Nullable<double> price { get; set; }
        [DataMember]
        public Nullable<int> quantity { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",Id,name,price,quantity);
        }
    }
}
