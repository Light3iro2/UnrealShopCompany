//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnrealShopCompany
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderList
    {
        public int Id { get; set; }
        public int IdClients { get; set; }
        public string Items { get; set; }
        public string Staff { get; set; }
        public double Premium { get; set; }
        public string Accept { get; set; }
    
        public virtual Clients Clients { get; set; }
    }
}
