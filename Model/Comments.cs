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
    
    public partial class Comments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comments()
        {
            this.Reply = new HashSet<Reply>();
        }
    
        public int ComId { get; set; }
        public System.DateTime ComTime { get; set; }
        public string ComContent { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> DynId { get; set; }
        public Nullable<int> ReplyId { get; set; }
    
        public virtual Dynamics Dynamics { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Reply { get; set; }
    }
}
