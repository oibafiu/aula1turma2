namespace ImoveisApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ImoveisApi.Models.UsuarioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ImoveisApi.Models.UsuarioContext context)
        {
            context.Usuarios.AddOrUpdate(i => i.Nome, new Models.Usuario()
            {
                Nome = "Fabio",
                DataNascimento = DateTime.Parse("11/06/1996"),
                Email = "faabio.oliver@outlook.com"
            });
            context.SaveChanges();

            var proprietarioId = context.Usuarios.FirstOrDefault(i => i.Nome == "Fabio").Id;

            context.Imoveis.AddOrUpdate(i => i.ProprietarioId, new Models.Imovel()
            {
                Cep = "85010-060",
                Logradouro = "Rua Coronel Lustosa",
                Bairro = "Centro",
                Municipio = "Guarapuava",
                Numero = 190,
                Complemento = "Casa",
                ProprietarioId = proprietarioId
            });

            context.SaveChanges();





        }
    }
}
