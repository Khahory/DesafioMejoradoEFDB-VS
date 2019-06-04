namespace DesafioMejorado_DataBaseFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ADO_ContextDB : DbContext
    {
        public ADO_ContextDB()
            : base("name=ADO_ContextDB")
        {
        }

        public virtual DbSet<PersonaSet> PersonaSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
