using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinho.Helpers
{
    public class PacienteHelper
    {
        readonly SqliteAsyncConnection _conn;

        public PacienteHelper(string path)
        {
            _conn = new SqliteAsyncConnection(path);
            _conn.CreateTableAsync<Paciente>().Wait();  
        }

        public Task<int> Insert(Paciente p)
        {
            return _conn.InsertAsync(p;
        }

        public Task<int> Update(Paciente p)
        {
            return _conn.UpdateAsync(p);
        }

        public Task<int> Delete(Paciente p)
        {
            return _conn.DeleteAsync(p);
        }

        public Task<List<Paciente>> GetAll()
        {
            return _conn.Table<Paciente>().ToListAsync();
        }

    }
}
