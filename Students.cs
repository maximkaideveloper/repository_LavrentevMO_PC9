//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LavrentevMO_PC9_TestDemoEkz_Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        public Students()
        {
            this.AttestationStudent = new HashSet<AttestationStudent>();
        }
    
        public string Login { get; set; }
        public string FIO_Student { get; set; }
        public int GroupNumber { get; set; }
    
        public virtual ICollection<AttestationStudent> AttestationStudent { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Users Users { get; set; }
    }
}
