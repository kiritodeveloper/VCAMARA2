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
    
    public partial class NOMINA
    {
        public int Id_Nomina { get; set; }
        public Nullable<int> Id_Empresa { get; set; }
        public Nullable<int> ArchivoId { get; set; }
        public int IDE_CONTRATO { get; set; }
        public string RUC_ORDE { get; set; }
        public string CTA_ORDE { get; set; }
        public string COD_TRAN { get; set; }
        public Nullable<int> TIP_MONE { get; set; }
        public Nullable<decimal> MON_TRAN { get; set; }
        public Nullable<System.DateTime> FEC_TRAN { get; set; }
        public string RUC_BENE { get; set; }
        public string NOM_BENE { get; set; }
        public Nullable<int> TIP_CTA { get; set; }
        public string CTA_BENE { get; set; }
        public string DET_TRAN { get; set; }
    
        public virtual CONTRATO_SYS CONTRATO_SYS { get; set; }
        public virtual Archivo Archivo { get; set; }
    }
}
