using Eureka.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.Composition;

namespace Eureka.Infra.EntityConfiguration
{
    [Export(typeof(IEntityConfiguration))]
    class ComentarioConfiguration : EntityTypeConfiguration<Comentario>, IEntityConfiguration
    {
        public ComentarioConfiguration()
        {
            HasKey(i => i.ComentarioID);

            ToTable("Coments");
            Property(i => i.Descricao).IsRequired().HasMaxLength(250);
            Property(i => i.Avaliacao).IsOptional();
            Property(i => i.Usuario).IsRequired();
        }

        public void AddConfiguration(ConfigurationRegistrar registrar)
        {
            registrar.Add(this);
        }
    }
}
