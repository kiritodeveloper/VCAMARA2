//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VidaCamara.DIS.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bitacora
    {
        public int IdBitacora { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdArchivo { get; set; }
        public string Descripcion { get; set; }
        public string Comando { get; set; }
    }
}