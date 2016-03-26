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
    
    public partial class HistorialCargaArchivo_LinCab
    {
        public HistorialCargaArchivo_LinCab()
        {
            this.HistorialCargaArchivo_LinDet = new HashSet<HistorialCargaArchivo_LinDet>();
        }
    
        public long IdHistorialCargaArchivoLinCab { get; set; }
        public Nullable<int> ArchivoId { get; set; }
        public int IDE_CONTRATO { get; set; }
        public string TIP_REGI { get; set; }
        public Nullable<System.DateTime> FEC_ENVI_ARC { get; set; }
        public Nullable<int> COD_CSV { get; set; }
        public Nullable<int> NUM_CONT_LIC { get; set; }
        public Nullable<int> MONEDA { get; set; }
        public string PER_CONT { get; set; }
        public string TIP_PAGO { get; set; }
        public Nullable<System.DateTime> FEC_PAGO { get; set; }
        public Nullable<int> CumpleValidacion { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FEC_REG { get; set; }
        public string USU_REG { get; set; }
        public Nullable<int> ArchivoIdNomina { get; set; }
    
        public virtual CONTRATO_SYS CONTRATO_SYS { get; set; }
        public virtual Archivo Archivo { get; set; }
        public virtual ICollection<HistorialCargaArchivo_LinDet> HistorialCargaArchivo_LinDet { get; set; }
    }
}
