using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioMejorado_DataBaseFirst.Service
{
    public class PersonaService
    {
        public List<PersonaSet> ObtenerTodos()
        {
            using (var db = new ADO_ContextDB())
            {
                //retorna la tista que creamos en BlogContexModel
                //debemos incluir en este query que queremos obtenerer los comentarios tambien
                return db.PersonaSet.ToList();
            }
        }

        internal void Crear(PersonaSet model)
        {
            using (var db = new ADO_ContextDB())
            {
                //anadimos el modelo a nuestra lista de blogPost
                db.PersonaSet.Add(model);
                //guardar cambios en la db
                db.SaveChanges();
            }
        }
    }
}