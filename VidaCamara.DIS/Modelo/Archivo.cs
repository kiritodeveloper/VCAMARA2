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
    
    public partial class Archivo
    {
        public Archivo()
        {
            this.NOMINAs = new HashSet<NOMINA>();
            this.HistorialCargaArchivoes = new HashSet<HistorialCargaArchivo>();
            this.HistorialCargaArchivo_LinCab = new HashSet<HistorialCargaArchivo_LinCab>();
        }
    
        public int ArchivoId { get; set; }
        public int EstadoArchivoId { get; set; }
        public int TipoArchivoId { get; set; }
        public string NombreArchivo { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<bool> Vigente { get; set; }
    
        public virtual ICollection<NOMINA> NOMINAs { get; set; }
        public virtual ICollection<HistorialCargaArchivo> HistorialCargaArchivoes { get; set; }
        public virtual ICollection<HistorialCargaArchivo_LinCab> HistorialCargaArchivo_LinCab { get; set; }
        public virtual EstadoArchivo EstadoArchivo { get; set; }
        public virtual TipoArchivo TipoArchivo { get; set; }
    }
}
