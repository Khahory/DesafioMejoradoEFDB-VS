using DesafioMejoradoEFDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioMejoradoEFDB.Service
{
    public class PersonaService
    {
        public List<PersonaModel> ObtenerTodos()
        {
            using (var db = new ApplicationDbContext())
            {
                //retorna la tista que creamos en BlogContexModel
                //debemos incluir en este query que queremos obtenerer los comentarios tambien
                return db.PersonaModels.ToList();
            }
        }

        internal void Crear(PersonaModel model)
        {
            using (var db = new ApplicationDbContext())
            {
                //anadimos el modelo a nuestra lista de blogPost
                db.PersonaModels.Add(model);
                //guardar cambios en la db
                db.SaveChanges();
            }
        }
    }
}