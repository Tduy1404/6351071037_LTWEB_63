//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHAXUATBAN
    {
        public NHAXUATBAN()
        {
            this.SACHes = new HashSet<SACH>();
        }
    
        public int MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
