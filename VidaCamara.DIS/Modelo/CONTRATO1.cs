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
    
    public partial class Contrato1
    {
        public Contrato1()
        {
            this.Siniestros = new HashSet<Siniestro>();
        }
    
        public int ContratoId { get; set; }
        public int Identificador { get; set; }
        public System.DateTime Periodo_FechaInicio { get; set; }
        public System.DateTime Periodo_FechaTermino { get; set; }
        public int TotalPartes { get; set; }
    
        public virtual ICollection<Siniestro> Siniestros { get; set; }
    }
}
