//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalorieCalculatorWF
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMenu
    {
        public int UserMenuId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> TypeEatingId { get; set; }
        public Nullable<int> ProductsId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Calorie { get; set; }
        public Nullable<int> WeightProduct { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual TypeEating TypeEating { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
