using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace ServidorJogoCartas.Shared.Repositorios
{
    public class Repositorio<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Create(T register)
        {
            _connection.Insert<T>(register);
        }

        public T Read(int id)
        {
            return _connection.Get<T>(id);
        }

        public IEnumerable<T> Read()
        {
            return _connection.GetAll<T>();
        }

        public void Upadte(T register)
        {
            _connection.Update<T>(register);
        }

        public void Delete(T register)
        {
            _connection.Delete<T>(register);
        }

        public void Delete(int id)
        {
            var register = _connection.Get<T>(id);
            _connection.Delete(register);
        }
    }
}
