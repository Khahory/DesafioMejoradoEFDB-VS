using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Service
{
    public class PersonaService
    {
        public List<Persona> ObtenerTodos()
        {
            using (var db = new ADO_PruebaContainer())
            {
                //retorna la tista que creamos en BlogContexModel
                //debemos incluir en este query que queremos obtenerer los comentarios tambien
                return db.PersonaSet.ToList();
            }
        }

        internal void Crear(Persona model)
        {
            using (var db = new ADO_PruebaContainer())
            {
                //anadimos el modelo a nuestra lista de blogPost
                db.PersonaSet.Add(model);
                //guardar cambios en la db
                db.SaveChanges();
            }
        }
    }
}