//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwAsignacionTribunales.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoPicExaman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoPicExaman()
        {
            this.EstudiantePicExamen = new HashSet<EstudiantePicExaman>();
        }
    
        public int IdTipoPicExamen { get; set; }
        public string Descripcion { get; set; }
        public string IsActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstudiantePicExaman> EstudiantePicExamen { get; set; }
    }
}
