namespace ServidorJogoCartas.Shared.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(bool validador, string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
            Validador = validador;
        }

        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
        public bool Validador { get; set; }
    }
}
