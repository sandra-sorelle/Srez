//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SrezGri.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderService
    {
        public int OrderServiceID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ServiceID { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
    }
}
