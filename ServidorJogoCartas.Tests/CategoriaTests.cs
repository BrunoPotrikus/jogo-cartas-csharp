using Microsoft.Data.SqlClient;
using ServidorJogoCartas.Domain.Models;
using ServidorJogoCartas.Shared.Repositorios;

namespace ServidorJogoCartas.Tests;

[TestClass]
public class CategoriaTests
{
    private const string CONNECTION_STRING = "Server=localhost,1433;" +
                                                  "Database=JogoCartas;" +
                                                  "User ID=sa;" +
                                                  "Password=H2g@5dT$;" +
                                                  "Trusted_Connection=False;" +
                                                  "TrustServerCertificate=True";

    [TestMethod]
    public void CadastraCategoria()
    {
        using(var connection = new SqlConnection(CONNECTION_STRING))
        {           
            var categoria = new Categoria("Místico", "https://images.wemystic.com.br/repo/765_360_smbolos-msticos-cruz-egipcia_1518781460.jpg");

            var repositorio = new Repositorio<Categoria>(connection);
            repositorio.Create(categoria);
            //foreach(var notificacao in categoria.ListaNotificacoes)
            //{
            //    Console.WriteLine(notificacao.Mensagem);
            //}
        }
    }
 }