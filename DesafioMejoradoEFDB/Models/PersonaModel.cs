using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesafioMejoradoEFDB.Models
{
    public class PersonaModel
    {
        //para que entity framwork se de cuenta que esto es un id para identificar cada BlogPost
        //por obligacion debemos poner solo *Id*
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [Range(18, 100)]
        public int Edad { get; set; }

        [Required]
        [StringLength(30)]
        public string Carrera { get; set; }

        [Required]
        [Range(1,25)]
        public int Cuatrimestre { get; set; }
    }
}