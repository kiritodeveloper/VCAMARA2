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
    
    public partial class Imputacion
    {
        public int ImputacionId { get; set; }
        public int Linea { get; set; }
        public string Correlativo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string CentroCosto { get; set; }
        public string CuentaContable { get; set; }
        public string Nit { get; set; }
        public int MonedaId { get; set; }
        public decimal Debe_Soles { get; set; }
        public decimal Haber_soles { get; set; }
        public decimal Debe_Dolares { get; set; }
        public decimal Haber_Dolares { get; set; }
        public string Fuente { get; set; }
        public string Referencia { get; set; }
        public int UsuarioModificacion { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public bool Vigente { get; set; }
        public Nullable<int> ArchivoId { get; set; }
    }
}