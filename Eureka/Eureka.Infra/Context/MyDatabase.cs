using Eureka.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Eureka.Infra.EntityConfiguration;

namespace Eureka.Infra.Context
{
    public class MyDatabase //: DbContext
    {
        public MyDatabase()
        //: base("DefaultConnection")
        {
            this.Ideias = new List<Ideia>();
            this.Comentarios = new List<Comentario>();
            Populate();
        }

        public List<Ideia> Ideias { get; set; }
        public List<Comentario> Comentarios { get; set; }

        private void Populate()
        {
            var ideia = new Ideia() { IdeiaID = 1, Titulo = "Eureka", Descricao = "asd a sd asd as d as d ad a d", Avaliacao = 0, Tag = "teste;fluentAPI;" };
            var ideia2 = new Ideia() { IdeiaID = 2, Titulo = "Autofac", Descricao = "Inverse of Control", Avaliacao = 10, Tag = "ioc;autofac" };

            var comentario = new Comentario() { ComentarioID = 1, Descricao = "dlkajdsasd ad adawelqjweoiquwoj qwjquweioqu eoiuqoweu qoeuoqueoq", Avaliacao = 0 };

            ideia.Comentarios.Add(comentario);

            Ideias.Add(ideia);
            Ideias.Add(ideia2);
            Comentarios.Add(comentario);
        }



        //public virtual IDbSet<Ideia> Ideias { get; set; }
        //public virtual IDbSet<Comentario> Comentarios { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //modelBuilder.Entity<Ideia>().Property(i => i.Descricao).IsRequired();
        //modelBuilder.Entity<Ideia>().Property(i => i.Tag).IsOptional();

        //modelBuilder.Configurations.Add(new IdeiaConfiguration());

        //modelBuilder.Entity<Comentario>().Property(i => i.Descricao).IsRequired();

        //EntityConfiguration(modelBuilder);

        //base.OnModelCreating(modelBuilder);
        //}

        private void EntityConfiguration(DbModelBuilder modelBuilder)
        {
            var contextConfiguration = new ContextConfiguration();
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            container.ComposeParts(contextConfiguration);

            foreach (var configuration in contextConfiguration.Configurations)
                configuration.AddConfiguration(modelBuilder.Configurations);
        }
    }
}
