using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViagensOnline.Dominio;

namespace ViagensOnline.Repositorios.MySql.Tests
{
    [TestClass()]
    public class ViagensOnlineDbContextTests
    {
        ViagensOnlineDbContext db = new ViagensOnlineDbContext();

        [TestMethod()]
        public void InserirDestinoTest()
        {
            var destino = new Destino();

            destino.Cidade = "São Paulo";
            destino.Nome = "Conheça São Paulo";
            destino.NomeImagem = "SP.png";
            destino.Pais = "Brasil";

            db.Destinos.Add(destino);

            db.SaveChanges();
        }
    }
}