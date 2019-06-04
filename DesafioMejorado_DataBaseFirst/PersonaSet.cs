namespace DesafioMejorado_DataBaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonaSet")]
    public partial class PersonaSet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [Range(18,99)]
        public int Edad { get; set; }

        [Required]
        [StringLength(20)]
        public string Carrera { get; set; }

        [Range(1, 25)]
        [Required]
        public int Cuatrimestre { get; set; }
    }
}
