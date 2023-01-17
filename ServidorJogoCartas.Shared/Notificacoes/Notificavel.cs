namespace ServidorJogoCartas.Shared.Notificacoes
{
    public class Notificavel
    {
        private IList<Notificacao> _notificacao;
        
        public Notificavel()
        {
          _notificacao = new List<Notificacao>();
        }

        //public IReadOnlyCollection<Notificacao> ListaNotificacoes { get { return _notificacao.ToArray(); } }

        public void AddNotificacao(bool validador, string propriedade, string mensagem)
        {
            //var notificacao = new Notificacao(validador, propriedade, mensagem);
            //_notificacao.Add(notificacao);
        }
    }
}
