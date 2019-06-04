using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMejoradoDB_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "s";

            using (var db = new ADO_PersonaContextContainer())
            {
                var persona = db.PersonaSet.Create();

                persona.Nombre = d;
                persona.Edad = 20;
                persona.Carrera = "Software es mi carrera";
                persona.Cuatrimestre = 7;

                db.PersonaSet.Add(persona);
                db.SaveChanges();
            }

            
        }
    }
}
