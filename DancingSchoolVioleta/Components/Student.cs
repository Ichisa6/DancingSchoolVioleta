//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DancingSchoolVioleta.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> GroupId { get; set; }
    
        public virtual Group Group { get; set; }
    }
}
