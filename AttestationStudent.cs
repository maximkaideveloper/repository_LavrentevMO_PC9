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
    
    public partial class AttestationStudent
    {
        public string FIO_Student { get; set; }
        public int Attestation_Number { get; set; }
        public int Mark { get; set; }
        public string Subject_Name { get; set; }
        public Nullable<System.DateTime> ThisMark_Date { get; set; }
        public string Description { get; set; }
    
        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
