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
    
    public partial class CONCEPTO
    {
        public int ID_CONCEPTO { get; set; }
        public int IDE_IMPRESA { get; set; }
        public string TIPO_TABLA { get; set; }
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string VALOR { get; set; }
        public string CLASE { get; set; }
        public string TIPO { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FEC_REG { get; set; }
        public string USU_REG { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<int> IS_EDITABLE { get; set; }
    }
}
