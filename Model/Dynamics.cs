//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dynamics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dynamics()
        {
            this.Dynamics1 = new HashSet<Dynamics>();
        }
    
        public int DynId { get; set; }
        public int ComId { get; set; }
        public int UserId { get; set; }
        public int ReplyComId { get; set; }
        public string DynamicContent { get; set; }
        public System.DateTime DynamicTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dynamics> Dynamics1 { get; set; }
        public virtual Dynamics Dynamics2 { get; set; }
    }
}
