namespace ConsoleMigration1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMigration1.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleMigration1.Model.MigrationContext";
        }

        protected override void Seed(ConsoleMigration1.Model.MigrationContext context)
        {

            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Usuarios.AddOrUpdate(i => i.Nome, new Model.Usuario()
            {


                Nome = "felipe",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com.br",
                Nivel = Model.Nivel.Visitante

            }) ;
            context.SaveChanges();
        }
    }
}
