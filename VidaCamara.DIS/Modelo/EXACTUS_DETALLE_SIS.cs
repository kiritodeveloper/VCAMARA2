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
    
    public partial class EXACTUS_DETALLE_SIS
    {
        public int IDE_EXACTUS_CABECERA_SIS { get; set; }
        public string ASIENTO { get; set; }
        public int CONSECUTIVO { get; set; }
        public string CENTRO_COSTO { get; set; }
        public string CUENTA_CONTABLE { get; set; }
        public string FUENTE { get; set; }
        public string REFERENCIA { get; set; }
        public string CONTRIBUYENTE { get; set; }
        public decimal MONTO_LOCAL { get; set; }
        public decimal MONTO_DOLAR { get; set; }
        public decimal MONTO_UNIDADES { get; set; }
        public System.DateTime FECHA_REGISTRO { get; set; }
        public string ESTADO_TRANSFERENCIA { get; set; }
        public string NIT { get; set; }
        public string DIMENSION1 { get; set; }
        public string DIMENSION2 { get; set; }
        public string DIMENSION3 { get; set; }
        public string DIMENSION4 { get; set; }
        public string DIMENSION5 { get; set; }
    
        public virtual EXACTUS_CABECERA_SIS EXACTUS_CABECERA_SIS { get; set; }
    }
}
