//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Empleados
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permisos
    {
        public int IdEmpleado { get; set; }
        public string Permiso { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
