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
    
    public partial class PoyectoVinculacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PoyectoVinculacion()
        {
            this.PracticaVinculacionEstudiantes = new HashSet<PracticaVinculacionEstudiante>();
        }
    
        public int IdProyecto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> DocenteCatedra { get; set; }
        public Nullable<int> Carrera { get; set; }
        public Nullable<int> Nivel { get; set; }
        public string ParaleloAsignado { get; set; }
        public Nullable<int> Modalidad { get; set; }
        public Nullable<int> AsignaturaRectoria { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticaVinculacionEstudiante> PracticaVinculacionEstudiantes { get; set; }
    }
}