//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planlama
    {
        public int PNo { get; set; }
        public Nullable<int> UNo { get; set; }
        public string PAdi { get; set; }
        public string BagliOlduguKurum { get; set; }
    
        public virtual Uretim Uretim { get; set; }
    }
}
