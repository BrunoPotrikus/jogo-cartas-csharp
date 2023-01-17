using Dapper.Contrib.Extensions;
using ServidorJogoCartas.Shared.Notificacoes;

namespace ServidorJogoCartas.Domain.Models
{
    [Table("[Categoria]")]
    public class Categoria : Notificavel
    {
        public Categoria(string titulo, string simbolo)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Simbolo = simbolo;

            AddNotificacao(Valido(Titulo), "Título-Categoria", "A Categoria precisa ter um título");
            AddNotificacao(Valido(Simbolo), "Símbolo-Categoria", "A Categoria precisa ter um símbolo");
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Simbolo { get; set; }

        public bool Valido(string parametro)
        {
            if (string.IsNullOrEmpty(parametro))
            {
                return false;
            }

            return true;
        }

        public bool Invalido()
        {
            if (string.IsNullOrEmpty(Titulo))
            {
                return true;
            }

            return false;
        }
    }
}
