using Eureka.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Infra.Context
{
    public class MyDatabase : DbContext
    {
        public MyDatabase()
            : base("ConnectionStringName")
        {

        }

        public virtual IDbSet<Ideia> Ideias { get; set; }
        public virtual IDbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
