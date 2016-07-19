namespace Eureka.Infra.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //internal sealed class Configuration : DbMigrationsConfiguration<Eureka.Infra.Context.MyDatabase>
    //{
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = false;
    //    }

    //    protected override void Seed(Eureka.Infra.Context.MyDatabase context)
    //    {
    //        var ideia = new Ideia() { IdeiaID = 1, Titulo = "Eureka", Descricao = "asd a sd asd as d as d ad a d", Avaliacao = 0, Tag = "teste;fluentAPI;" };
    //        var ideia2 = new Ideia() { IdeiaID = 2, Titulo = "Autofac", Descricao = "Inverse of Control", Avaliacao = 10, Tag = "ioc;autofac" };

    //        var comentario = new Comentario() { ComentarioID = 1, Descricao = "dlkajdsasd ad adawelqjweoiquwoj qwjquweioqu eoiuqoweu qoeuoqueoq", Avaliacao = 0 };

    //        ideia.Comentarios.Add(comentario);
            
    //        context.Ideias.AddOrUpdate(i => i.IdeiaID, ideia, ideia2);
    //        //  This method will be called after migrating to the latest version.

    //        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
    //        //  to avoid creating duplicate seed data. E.g.
    //        //
    //        //    context.People.AddOrUpdate(
    //        //      p => p.FullName,
    //        //      new Person { FullName = "Andrew Peters" },
    //        //      new Person { FullName = "Brice Lambson" },
    //        //      new Person { FullName = "Rowan Miller" }
    //        //    );
    //        //
    //    }
    //}
}
