using Eureka.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Infra.EntityConfiguration
{
    public class IdeiaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ideia>
    {
        public IdeiaConfiguration()
        {
            //HasKey(ideia=> ideia.Id)

            Property(i => i.Descricao).IsRequired();
            
            HasMany(i => i.Comentarios).WithRequired().WillCascadeOnDelete(true);
        }
    }
}